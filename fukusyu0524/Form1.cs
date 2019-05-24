using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0524
{
    
    public partial class Form1 : Form
    {
    int a,b;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += a;
            label1.Top += b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
            b = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 0;
            b = -1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = -1;
            b = 0;
        }
    }
}
