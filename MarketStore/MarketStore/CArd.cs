using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace MarketStore
{
    public class Card
    {
        
        public Card(string name,CardType type, decimal turnover)
        {
            this.HolderName = name;           
            this.Type = type;
            this.Turnover = turnover;
            this.DiscountRate = CalculateDiscountRateByType(this.Type);
        }

        public string HolderName { get; set; }
        public string Number { get; set; }
        public CardType Type { get; set; }
        public decimal Turnover { get; set; }
        public decimal DiscountRate { get; set; }

        private decimal CalculateDiscountRateByType(CardType type)
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
                    if (this.Turnover >= 300)
                    {
                        return Constants.SilverCardDiscount;
                    }
                    else
                    {
                        return Constants.SilverCardInitialDiscount;
                    }

                case CardType.Gold:
                    decimal addedDiscount = (decimal) this.Turnover / 100 + Constants.GoldCardInitialDiscount;
                    if (addedDiscount < Constants.GoldCardMaxDiscount)
                    {
                        return addedDiscount;
                    }
                    else
                    {
                        return Constants.GoldCardMaxDiscount;
                    }

                default:
                    throw new Exception();
            }
        }
    }
}