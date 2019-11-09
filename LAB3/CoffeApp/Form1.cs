using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (str=="")
            {
                MessageBox.Show("Please Enter a number");
                textBox1.Focus();            
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter==5)
            {
                comboBox1.Items.Add("Free");
                MessageBox.Show("You Won Free Drink");
                counter = 0;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int quantity;
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (!int.TryParse(str,out quantity))
                {
                    MessageBox.Show("Please Enter a number");
                }
                else
                {
                    string sizeStr = comboBox1.SelectedItem.ToString();
                    switch(sizeStr)
                    {
                        case "Small":
                            if (MessageBox.Show(5 * quantity + " TL", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show("Small Afiyet Olsun");
                            }
                            textBox1.Text = "";
                            break;
                        case "Medium":
                            if (MessageBox.Show(10 * quantity + " TL", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show("Medium Afiyet Olsun");
                            }
                            textBox1.Text = "";
                            break;
                        case "Large":
                            if (MessageBox.Show(15 * quantity + " TL", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show("Large Afiyet Olsun");
                            }
                            textBox1.Text = "";
                            break;
                        case "Free":
                            if (MessageBox.Show("Free", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                MessageBox.Show("Free");
                            }
                            textBox1.Text = "";
                            break;
                        default:
                            MessageBox.Show("Not Entered");
                            break;

                    }
                }
            }
        }
    }
}
