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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label3.Visible = false;
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2_f2.Text = Convert.ToString(numero_random_obtenido);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = metodos.NumeroPrimo(Convert.ToInt32(txb1_f2.Text.Trim()));
            label3.Visible = true;
            label3.Text = respuesta;
            listBox1.DataSource = metodos.Multiplos(Convert.ToInt32(txb2_f2.Text.Trim()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2_f2.Text = Convert.ToString(numero_random_obtenido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            txb1_f2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fmr3 = new Form3();
            fmr3.Show();
            
        }
    }
}
