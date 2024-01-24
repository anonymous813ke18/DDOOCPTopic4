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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    label1.Text += "*";
                }
                label1.Text += "\n";
            }
        }
    }
}
