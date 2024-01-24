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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text), fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            MessageBox.Show("The factorial is = " + fact);
        }
    }
}
