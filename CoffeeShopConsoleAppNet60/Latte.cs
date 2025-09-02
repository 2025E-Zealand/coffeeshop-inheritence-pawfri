using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(int discount) 
            : base(discount)
        {
        }

        public override int Price()
        {
            if (Discount <= 5)
            {
                return 40 - Discount;
            }
            else
            {
                throw new ArgumentException("The Discount is too large, decrease it to maximumu 5 kr.");
            }
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
