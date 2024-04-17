using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Vollmondschwert", 5000, 90, 110));
            _standardGameItems.Add(new Weapon(1002, "Roteisenklinge", 6500, 120, 140));

        }

        public static GameItem CreateGameItem(int itemID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemId == itemID);

            if(standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }

    }
}
