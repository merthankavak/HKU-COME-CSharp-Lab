using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectNumber
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
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum==number)
                    MessageBox.Show("Entered number is a perfect number");
                else
                    MessageBox.Show("Entered number is NOT a perfect number");

            }
        }
    }
}
