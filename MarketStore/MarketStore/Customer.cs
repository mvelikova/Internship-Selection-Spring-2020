using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
            this.Items=new List<Item>();
        }
        public string Name { get; set; }
        public Card Card { get; set; }
        public List<Item> Items { get; set; }
    }
}