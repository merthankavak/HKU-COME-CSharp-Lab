using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int number;
            if (!int.TryParse(str, out number)) 
            {
                MessageBox.Show("Please Enter a Number");
            }
            else
            {
                int counter = 0;
                for (int i=2;i<=number/2;i++)
                {
                    if (number % i ==0)
                    {
                        counter++;
                    }
                }
                if (counter > 1 && number != 1)
                    MessageBox.Show("Not a Prime Number");
                else
                    MessageBox.Show("Prime Number");

            }
        }
    }
}
