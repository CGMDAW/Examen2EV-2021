using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

         // Declaramos la constante que convierte entre euros y dolares.
        //
        const double CONV1 = 0.826;  // 1 dolar, 0,826 euros
        const double CONV2 = 1.1485; // 1 libra, 1,1485 euros

        private void btDolaresAEuros_Click(object sender, EventArgs e)
        {
            double euros, dolares;

            dolares = double.Parse(tImporte.Text);
            euros = dolares * CONV1;

            tResultado.Text = euros.ToString();
        }

        private void btEurosADolares_Click(object sender, EventArgs e)
        {
            double euros, dolares;

            euros = double.Parse(tImporte.Text);
            dolares = euros * CONV1;

            tResultado.Text = dolares.ToString();
        }

        private void btLibrasAEuros_Click(object sender, EventArgs e)
        {
            double euros, libras;

            libras = double.Parse(tImporte.Text);
            euros = libras * CONV1;

            tResultado.Text = euros.ToString();
        }

        private void btEurosALibras_Click(object sender, EventArgs e)
        {
            double euros, libras;

            euros = double.Parse(tResultado.Text);
            libras = euros / CONV1;

            tImporte.Text = libras.ToString();
        }
    }
}
