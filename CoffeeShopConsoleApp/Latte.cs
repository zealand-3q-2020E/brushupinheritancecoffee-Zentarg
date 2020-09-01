using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte()
        {
            Discount = 4;
        }

        public override int price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }
}
