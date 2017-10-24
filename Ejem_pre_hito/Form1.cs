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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2.Text = Convert.ToString(numero_random_obtenido);
        }

        private void btn_Click(object sender, EventArgs e)
        {
           string respuesta = metodos.NumeroPrimo(Convert.ToInt32(txb1.Text.Trim()));
           label4.Visible = true;
           label4.Text = respuesta;
           int resultado = metodos.Operacion(respuesta, Convert.ToInt32(txb1.Text.Trim()), Convert.ToInt32(txb2.Text.Trim()));
           txb3.Text = Convert.ToString(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2.Text = Convert.ToString(numero_random_obtenido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero_random_obtenido = metodos.NumeroRandom();
            txb2.Text = Convert.ToString(numero_random_obtenido);
            txb1.Clear();
            txb3.Clear();
            label4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm_dos = new Form2();
            frm_dos.Show();
        }

       

       
    }
}
