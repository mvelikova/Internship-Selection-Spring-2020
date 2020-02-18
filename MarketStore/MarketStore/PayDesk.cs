using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MarketStore
{
    public class PayDesk
    {
        public PayDesk()
        {
            this.Customers=new List<Customer>();
        }
        private decimal PurchaseValue { get; set; }
        private decimal DiscountRate { get; set; }
        private decimal Discount { get; set; }
        private decimal Total { get; set; }

        private List<Customer> Customers { get; set; }

        public void AddCustomers(IList<Customer> customers)
        {
            Customers.AddRange(customers);
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void ProcessCustomers()
        {
            foreach (var customer in Customers)
            {
                this.PurchaseValue = SumTotalPrice(customer);
                this.DiscountRate = customer.Card.DiscountRate;
                this.Discount = this.DiscountRate * this.PurchaseValue;
                this.Total = this.PurchaseValue - this.Discount;
                ShowCustomerInfo();
            }
        }

        private void ShowCustomerInfo()
        {
            Console.WriteLine("Purchase value: "+this.PurchaseValue.ToString("C2"));
            Console.WriteLine("Discount rate:  "+this.DiscountRate.ToString("P1"));
            Console.WriteLine("Discount: "+this.Discount.ToString("C2"));
            Console.WriteLine("Total: "+this.Total.ToString("C2"));
            Console.WriteLine();
        }
        private decimal SumTotalPrice(Customer customer)
        {
            return customer.Items.Sum(x => x.Price);
        }
    }
}