using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismAndInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totProf(Animal [] A)
        {
            double tot = 0.0;
            for int i=0; i < 10; i++)
            {

            }
            return (tot);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal[] myFarm = new Animal[10];
            for (int i = 0; i < 10; i++)
            {
                myFarm[i] = new Cow(i + 100, i * 23.5);
            }
            double prof = 0;
            for (int i = 0; i < 10; i++)
            {
                prof += myFarm[i].getProf();
            }

            //double prof = 0.0;
            //for (int i = 0; i < myFarm.length; i++)
            //prof += myFarm[i].getprof();
        }
    }
}
