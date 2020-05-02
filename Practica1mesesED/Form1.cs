using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1mesesED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] meses = new string[13];
            meses[0] = "Enero\n, Febrero\n, Marzo\n, Abril\n, Mayo\n, Junio\n, Julio\n, Agosto\n, Septiembre\n, Octubre\n, Noviembre\n, Diciembre\n";
            meses[1] = "Enero";
            meses[2] = "Febrero";
            meses[3] = "Marzo";
            meses[4] = "Abril";
            meses[5] = "Mayo";
            meses[6] = "Junio";
            meses[7] = "Julio";
            meses[8] = "Agosto";
            meses[9] = "Septiembre";
            meses[10] = "Octubre";
            meses[11] = "Noviembre";
            meses[12] = "Diciembre";
            label5.Text = meses[int.Parse(textBox1.Text)];
        }
    }
}
