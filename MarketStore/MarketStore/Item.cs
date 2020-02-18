using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MarketStore
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public String Name { get; set; }
        public decimal Price { get; set; }
    }
}