using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    class Cow: Animal
    {
        public double amtMilk;
        public Cow(int id, double amtMilk) : base(id) { this.amtMilk = amtMilk; }

        public override double getProf()
        {
            double profit;
            profit = this.amtMilk * Prices.cowMilkPrice - Prices.cowVaccPrice;
            return profit;
        }
    }
}
