using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {

        public BlackCoffee()
        {
            Discount = 1;
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
