using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int anga, angb, angc, sum = 180;
        private void generateRandomButton_Click(object sender, EventArgs e)
        {
            anga = generateRandomNumber(178);
            angb = generateRandom(sum - anga - 1);
            angc = sum - angb - anga;
        }
        public static int generateRandom(int max)
        {
            Random random = new Random();
            return random.Next(1, max);


        }
    }
}
