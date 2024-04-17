using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinDmg {  get; set; }
        public int MaxDmg { get; set; }
        public Weapon(int itemId, string name, int price, int minDmg, int maxDmg) : base(itemId, name, price) 
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        }
        // new damit wird die Clone methode aus GameItem überschreiben können 
        public new Weapon Clone()
        {
            return new Weapon(ItemId, Name, Price, MinDmg, MaxDmg);
        }
    }
}
