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

        private double totProf(Dictionary<int, Animal> myFarm)
        {
            double profit = 0;
            foreach(var animal in myFarm.Values)
            {
                profit += animal.getProf();
            }
            return profit;
        }

        private void BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDia = new OpenFileDialog();

            FileDia.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            FileDia.FilterIndex = 2;
            FileDia.RestoreDirectory = true;
            if(FileDia.ShowDialog() == DialogResult.OK)
            {
                BrowseFileTextBox.Text = FileDia.FileName;
            }
        }

        private void buttonCalculateButton_press(object sender, EventArgs e)
        {
            Dictionary<int, Animal> myFarm = new Dictionary<int, Animal>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@BrowseFileTextBox.Text);
            int i = 0;
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                if (values[2] == "Cow")
                {
                    //myFarm[i] = new Cow(int.Parse(values[0]), double.Parse(values[1]));
                    myFarm.Add(int.Parse(values[0]), new Cow(int.Parse(values[0]), double.Parse(values[1])));
                }
                else if (values[2] == "Jersey_Cow")
                {
                    //myFarm[i] = new JerseyCow(int.Parse(values[0]), double.Parse(values[1]));
                    myFarm.Add(int.Parse(values[0]), new Cow(int.Parse(values[0]), double.Parse(values[1])));
                }
                else if (values[2] == "Goat")
                {
                    //myFarm[i] = new Goat(int.Parse(values[0]), double.Parse(values[1]));
                    myFarm.Add(int.Parse(values[0]), new Cow(int.Parse(values[0]), double.Parse(values[1])));
                }
                i++;
            }
            file.Close();
            Prices.cowMilkPrice = Convert.ToDouble(CowMilkTextBox.Text);
            Prices.goatMilkPrice = Convert.ToDouble(GoatMilkTextBox.Text);
            Prices.cowVaccPrice = Convert.ToDouble(CowVaccTextBox.Text);
            Prices.jcowVaccPrice = Convert.ToDouble(JCowVaccTextBox.Text);
            Prices.goatVaccPrice= Convert.ToDouble(GoatVacTextBox.Text);
            ProfitTextBox.Text = "$" + totProf(myFarm).ToString();
        }

        private void BrowseFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoatVacTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoatMilkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CowVaccTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CowMilkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JCowVaccTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
