using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    class JerseyCow: Cow
    {
        public JerseyCow(int id, double amtMilk) : base(id, amtMilk) {; }

        override public double getProf()
        {
            return (50.0);
        }
    }
}
