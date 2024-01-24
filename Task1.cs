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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text), sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }
            MessageBox.Show("The Sum is = " + sum);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
