using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            string n1 = number1.Text;
            int num1 = int.Parse(n1);
            string n2 = number2.Text;
            int num2 = int.Parse(n2);
            int sum = num1 + num2;
            resultTxtBox.Text = sum.ToString();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            string n1 = number1.Text;
            int num1 = int.Parse(n1);
            string n2 = number2.Text;
            int num2 = int.Parse(n2);
            int sub = num1 - num2;
            resultTxtBox.Text = sub.ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            string n1 = number1.Text;
            int num1 = int.Parse(n1);
            string n2 = number2.Text;
            int num2 = int.Parse(n2);
            int mul = num1 * num2;
            resultTxtBox.Text = mul.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            string n1 = number1.Text;
            int num1 = int.Parse(n1);
            string n2 = number2.Text;
            int num2 = int.Parse(n2);
            int div = num1 / num2;
            resultTxtBox.Text = div.ToString();
        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
