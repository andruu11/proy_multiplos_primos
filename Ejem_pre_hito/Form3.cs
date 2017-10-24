using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem_pre_hito
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2_f2.Text = Convert.ToString(numero_random_obtenido);
            label3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = metodos.NumeroPrimo(Convert.ToInt32(txb1_f2.Text.Trim()));
            label3.Visible = true;
            label3.Text = respuesta;
            listBox1.DataSource = metodos.Multiplos(Convert.ToInt32(txb2_f2.Text.Trim()));
            listBox2.DataSource = metodos.MultiplosPrimos(Convert.ToInt32(txb2_f2.Text.Trim()));
            listBox3.DataSource = metodos.MultiplosCompuestos(Convert.ToInt32(txb2_f2.Text.Trim()));
            textBox1.Text = Convert.ToString(metodos.Factorial(Convert.ToInt32(txb1_f2.Text.Trim())));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2_f2.Text = Convert.ToString(numero_random_obtenido);
        }
    }
}
