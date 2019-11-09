using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hkucinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movie = { "Star Wars", "Avengers", "Captain America", "IronMan" };
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", " Friday", "Saturday", "Sunday" };
            string[] sessions = new string[6];
            int counter = 10;
            for (int i = 0; i < sessions.Length; i++)
            {
                sessions[i] = counter + ":00";
                counter += 2;
            }
            comboBox1.Items.AddRange(movie);
            comboBox2.Items.AddRange(sessions);
            comboBox3.Items.AddRange(day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string control = textBox1.Text;
            string control2 = textBox2.Text;
            string control3 = textBox3.Text;
            int quantity;
            if (!string.IsNullOrWhiteSpace(control) && !string.IsNullOrWhiteSpace(control2) && !string.IsNullOrWhiteSpace(control3))
            {
                if (!int.TryParse(control, out quantity) && !int.TryParse(control2, out quantity) && !int.TryParse(control3, out quantity))
                {
                    MessageBox.Show("Please Enter String");
                }
                else
                {
                    string nameStr = textBox1.Text.ToString();
                    int age = int.Parse(textBox2.Text.ToString()), price = 20;
                    string number = textBox3.Text.ToString();
                    if (age < 20)
                        price = 15;
                    string chosenMov = comboBox1.SelectedItem.ToString(), chosenDay = comboBox2.SelectedItem.ToString(), chosenSes = comboBox3.SelectedItem.ToString();
                    if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1)
                    {
                        string str = "Hello" + nameStr + "\n Movie:" + chosenMov + "\n Day:" + chosenDay + "\n Session:" + chosenSes + "\n Price:" + price;
                        DialogResult result = MessageBox.Show(str, "Do you confirm", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("Congratulations");
                        }
                        else
                        //{
                            MessageBox.Show("See you..");
                        }
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Please Enter Something");
            }
        }
    }
}
