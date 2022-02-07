using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 u1 = new Form2();
            u1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 u2 = new Form3();
            u2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 u3 = new Form4();
            u3.Show();
        }
    }
}
