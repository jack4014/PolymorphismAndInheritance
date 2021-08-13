﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    class Goat : Animal
    {
        public double amtMilk;
        public Goat(int id, double amtMilk) : base(id) { this.amtMilk = amtMilk; }

        public override double getProf()
        {
            double profit;
            profit = this.amtMilk * Prices.cowMilkPrice - Prices.goatVaccPrice;
            return profit;
        }
    }
}
