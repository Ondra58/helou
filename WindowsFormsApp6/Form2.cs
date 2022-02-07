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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int max = -16, min = 60, poradi = 1, poradimaxima = 0, poradiminima = 0, pocetmaxim, pocetminim, soucet = 0;
                double prumer;
                int cislo = int.Parse(textBox1.Text);
                if (cislo <= 0)
                {
                    MessageBox.Show("Počet náhodných čísel musí být alespoň 1.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    while (cislo > 0)
                    {
                        Random rng = new Random();
                        int random = rng.Next(-15, 60);
                        listBox1.Items.Add(random);
                        if (random >= max)
                        {
                            max = random;
                            poradimaxima = poradi;
                        }
                        if (random < min)
                        {
                            min = random;
                            poradiminima = poradi;
                        }
                        cislo--;
                        poradi++;
                    }
                    label3.Text = "Maximum posloupnosti je " + max + " a nachází se na " + poradimaxima + ". pozici.";
                    label4.Text = "Minimum posloupnosti je " + min + " a nachází se na " + poradiminima + ". pozici.";
                    label3.Visible = true;
                    label4.Visible = true;
                    //prumer = ((double)soucet - pocetmaxim * max - pocetminim * min) / poradi - 1; 
                }
            }
            catch
            {
                MessageBox.Show("Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
