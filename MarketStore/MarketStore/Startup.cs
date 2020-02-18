using System;
using System.Globalization;
using System.Linq;

namespace MarketStore
{
    class Startup
    {
        static void Main(string[] args)
        {
            var paydesk1 = new PayDesk();
            var cust1 = new Customer("Cust1");
            var cust2 = new Customer("Cust2");
            var cust3 = new Customer("Cust3");
            var cust4 = new Customer("Cust4");


            var item1 = new Item("Item1", 150);
            var item2 = new Item("Item2", 850);
            var item3 = new Item("Item3", 1300);


            cust1.Card = new Card(cust1.Name, CardType.Brozne, 0);
            cust1.Items.Add(item1);

            cust2.Card = new Card(cust2.Name, CardType.Silver, 600);
            cust2.Items.Add(item2);

            cust3.Card = new Card(cust3.Name, CardType.Gold, 1500);
            cust3.Items.Add(item3);

            cust4.Card = new Card(cust4.Name, CardType.Gold, 300);
            cust4.Items.Add(item1);
            cust4.Items.Add(item2);


            paydesk1.AddCustomer(cust1);
            paydesk1.AddCustomer(cust2);
            paydesk1.AddCustomer(cust3);
            paydesk1.AddCustomer(cust4);

            paydesk1.ProcessCustomers();
        }
    }
}