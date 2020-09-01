using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {

        public Coffee()
        {
            Discount = 0;
        }

        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20 - Discount;
        }

        private int _discount;

        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value > 5)
                    throw new ArgumentOutOfRangeException(nameof(Discount),"Discount cannot be larger than 5.");
                _discount = value;
            }
        }


        public abstract string Strength();

        public override string ToString()
        {
            return $"Price: {price()} | Strength: {Strength()}";
        }
    }
}
