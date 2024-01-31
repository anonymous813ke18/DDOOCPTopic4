using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic4
{
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text), b = 1;
            for (int i = 1; i < 2*num; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    label1.Text += "* ";
                }
                if (i < ((num*2) / 2))
                    b++;
                else
                    b--;
                label1.Text += "\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
