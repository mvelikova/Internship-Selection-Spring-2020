using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    static class Constants
    {
        //Brozne card discounts
        public const decimal BronzeCardInitialDiscount = 0.0m;
        public const decimal BronzeCardMaxDiscount = 0.025m;
        public const decimal BronzeCardDiscount = 0.01m;

        //Silver card discounts
        public const decimal SilverCardInitialDiscount = 0.02m;
        public const decimal SilverCardDiscount = 0.035m;

        //Gold card discount
        public const decimal GoldCardInitialDiscount = 0.02m;
        public const decimal GoldCardDiscountGrowRate = 0.01m;
        public const decimal GoldCardMaxDiscount = 0.10m;


    }
}
