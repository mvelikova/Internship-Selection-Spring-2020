using System;
using System.Globalization;
using System.Linq;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var paydesk1 = new PayDesk();
            var cust1 = new Customer("Cust1");
            var cust2 = new Customer("Cust2");
            var cust3 = new Customer("Cust3");

            cust1.Card = new Card(cust1.Name, CardType.Brozne, 0);
            cust1.Items.Add(new Item("Item1", 150));

            cust2.Card = new Card(cust2.Name, CardType.Silver, 600);
            cust2.Items.Add(new Item("Item1", 850));

            cust3.Card = new Card(cust3.Name, CardType.Gold, 1500);
            cust3.Items.Add(new Item("Item1", 1300));

            paydesk1.AddCustomer(cust1);
            paydesk1.AddCustomer(cust2);
            paydesk1.AddCustomer(cust3);

            paydesk1.ProcessCustomers();
        }
    }
}