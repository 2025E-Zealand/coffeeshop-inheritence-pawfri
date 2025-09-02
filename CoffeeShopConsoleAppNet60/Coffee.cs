using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }

        protected Coffee(int discount)
        {
            Discount = discount;
        }

        public virtual int Price()
        {
            if (Discount <= 5)
            {
                return 20 - Discount;
            }
            else
            {
                throw new ArgumentException("The Discount is too large, decrease it to maximumu 5 kr.");
            }
             
        }

        public abstract string Strength();
    }
}
