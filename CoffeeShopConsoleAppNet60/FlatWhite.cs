using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60;

public class FlatWhite : Coffee, IMilk
{
    public FlatWhite(int discount, string name)
: base(discount, name)
    {
    }

    public override int Price()
    {
        if (Discount <= 5)
        {
            return 25 - Discount;
        }
        else
        {
            throw new ArgumentException("The Discount is too large, decrease it to maximumu 5 kr.");
        }
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
