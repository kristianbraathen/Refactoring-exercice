using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Exerc
{
     class Items
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Items(string name,int price)
        {
            Price= price;
            Name = name;

            Item = new List<Items>();
            
        }
        public List<Items> Item { get; set; }
        public string Print()
        {
            return "Item: " + Name + " Price: " + Price;
        }

    }
}
