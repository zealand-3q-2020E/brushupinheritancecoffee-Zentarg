using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {

        public Cortado()
        {
            Discount = 2;
            Blend = "Esmeralda";
        }

        public override int price()
        {
            return 25;
        }


        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }
    }
}
