using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    class JerseyCow: Cow
    {
        public JerseyCow(int id, double amtMilk) : base(id, amtMilk) 
        { 
        }

        override public double getProf()
        {
            double profit;
            profit = this.amtMilk * Prices.cowMilkPrice - Prices.jcowVaccPrice;
            return profit;
        }
    }
}
