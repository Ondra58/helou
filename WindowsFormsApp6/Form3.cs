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
    public partial class Form3 : Form
    {
        Form parentform;
        private static Random rng = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                bool pravdivost = false;
                int cislo = int.Parse(textBox1.Text);
                if (cislo <= 0)
                {
                    MessageBox.Show("Počet náhodných čísel musí být alespoň 1.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for(int i = 0; i < cislo; i++)
                    {
                        Random rng = new Random();
                        double random = rng.Next(-5, 21);
                        listBox1.Items.Add(random);
                        if (random > 2 && random <= 5)
                        {
                            pravdivost = true;
                            break;
                        }
                    }
                }
                if (pravdivost == true)
                {
                    label3.Text = "Posloupnost obsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
                else
                {
                    label3.Text = "Posloupnost neobsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                bool pravdivost = false;
                int cislo = int.Parse(textBox1.Text);
                if (cislo <= 0)
                {
                    MessageBox.Show("Počet náhodných čísel musí být alespoň 1.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < cislo && pravdivost != true; i++)
                    {
                        Random rng = new Random();
                        double random = rng.Next(-5, 21);
                        listBox1.Items.Add(random);
                        if (random > 2 && random <= 5)
                        {
                            pravdivost = true;
                        }
                    }
                }
                if(pravdivost == true)
                {
                    label3.Text = "Posloupnost obsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
                else
                {
                    label3.Text = "Posloupnost neobsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                bool pravdivost = false;
                int cislo = int.Parse(textBox1.Text);
                if (cislo <= 0)
                {
                    MessageBox.Show("Počet náhodných čísel musí být alespoň 1.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    while (cislo > 0 && pravdivost != true)
                    {
                        Random rng = new Random();
                        double random = rng.Next(-5, 21);
                        listBox1.Items.Add(random);
                        if (random > 2 && random <= 5)
                        {
                            pravdivost = true;
                        }
                        cislo--;
                    }
                }
                if (pravdivost == true)
                {
                    label3.Text = "Posloupnost obsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
                else
                {
                    label3.Text = "Posloupnost neobsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                bool pravdivost = false;
                int cislo = int.Parse(textBox1.Text);
                if (cislo <= 0)
                {
                    MessageBox.Show("Počet náhodných čísel musí být alespoň 1.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    do
                    {
                        Random rng = new Random();
                        double random = rng.Next(-5, 21);
                        listBox1.Items.Add(random);
                        if (random > 2 && random <= 5)
                        {
                            pravdivost = true;
                        }
                        cislo--;
                    } while (cislo > 0 && pravdivost != true);
                }
                if (pravdivost == true)
                {
                    label3.Text = "Posloupnost obsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
                else
                {
                    label3.Text = "Posloupnost neobsahuje číslo z intervalu (2;5>.";
                    label3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
