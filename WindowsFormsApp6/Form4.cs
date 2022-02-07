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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int lichych = 0, min = 2147483647, soucin = 1, max = -2147483647, cifra, cifsoucet = 0;
                foreach (string s in textBox1.Lines)
                {
                    int cislo = int.Parse(s);
                    if (cislo % 2 != 0)
                    {
                        lichych++;
                    }
                    if (cislo < min)
                    {
                        min = cislo;
                    }
                    if (cislo >= 5 && cislo < 20)
                    {
                        soucin *= cislo;
                    }
                    if (cislo > max)
                    {
                        max = cislo;
                    }
                }
                while (max > 0)
                {
                    cifra = max % 10;
                    cifsoucet += cifra;
                    max /= 10;
                }
                label3.Text = "Počet lichých čísel je " + lichych + ".";
                label6.Text = "Nejmenší číslo je " + min + ".";
                if (soucin != 1)
                {
                    label4.Text = "Součin čísel ležících v intervalu <5;20) je " + soucin + ".";
                }
                else
                {
                    label4.Text = "Žádné číslo neleží v intervalu <5;20).";
                }
                label5.Text = "Ciferný součet největšího čísla je " + cifsoucet + ".";
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
