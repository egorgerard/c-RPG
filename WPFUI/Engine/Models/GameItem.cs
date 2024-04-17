using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public GameItem(int itemId, string name, int price)
        {
            ItemId = itemId;
            Name = name;
            Price = price;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemId, Name, Price);
        }
    }
}
