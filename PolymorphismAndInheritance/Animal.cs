using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInheritance
{
    class Animal
    {
        public int id;
        public Animal(int id) { this.id = id; }
        virtual public double getProf()
        {
            return (150);
        }
    }
}
