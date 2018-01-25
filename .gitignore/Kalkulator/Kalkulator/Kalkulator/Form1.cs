using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(textBox1.Text);
            int liczba2 = Convert.ToInt32(textBox2.Text);
            int sumaLiczb = liczba1 + liczba2;
            textBox3.Text = sumaLiczb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(textBox1.Text);
            int liczba2 = Convert.ToInt32(textBox2.Text);
            int roznicaLiczb = liczba1 - liczba2;
            textBox3.Text = roznicaLiczb.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(textBox1.Text);
            int liczba2 = Convert.ToInt32(textBox2.Text);
            int iloczynLiczb = liczba1 * liczba2;
            textBox3.Text = iloczynLiczb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(textBox1.Text);
            int liczba2 = Convert.ToInt32(textBox2.Text);
            
            if (liczba2 == 0)
            {
                textBox3.Text = "Nie wolno dzielić przez zero!";
            }
            else
            {
                int ilorazLiczb = liczba1 / liczba2;
                textBox3.Text = ilorazLiczb.ToString();
            }
        }
    }
}
