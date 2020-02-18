using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace MarketStore
{
    public class Card
    {
        public Card()
        {
        }

        public Card(string name, string number, CardType type, decimal turnover)
        {
            this.HolderName = name;
            this.Number = number;
            this.Type = type;
            this.Turnover = turnover;
            this.Discount = CalculateDiscountRateByType(this.Type);
        }

        public string HolderName { get; set; }
        public string Number { get; set; }
        public CardType Type { get; set; }
        public decimal Turnover { get; set; }


        public double Discount { get; set; }

        private double CalculateDiscountRateByType(CardType type)
        {
            switch (type)
            {
                case CardType.Brozne:

                    if (this.Turnover >= 100 && this.Turnover < 300)
                    {
                       return Constants.BronzeCardDiscount;
                    }
                    else if (this.Turnover >= 300)
                    {
                        return Constants.BronzeCardMaxDiscount;
                    }
                    else
                    {
                        return Constants.BronzeCardInitialDiscount;
                    }
                    
                case CardType.Silver:
                    return Constants.SilverCardInitialDiscount;
                case CardType.Gold:
                    return Constants.GoldCardInitialDiscount;

                default:
                    return Constants.BronzeCardDiscount;
            }
        }
    }
}