using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {
        public FlatWhite()
        {
            Discount = 0;
            Blend = "Kieni";
        }

        public override int price()
        {
            return 35;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 150;
        }
    }
}
