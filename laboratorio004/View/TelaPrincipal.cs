using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio004
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (tbxnum.Text == "")
            {
                MessageBox.Show("insira um numero");
            }
            else { 
            int numero = 0;
            int quadrado = 0;
            numero = Convert.ToInt32(tbxnum.Text);
            quadrado = numero * numero;

            lblresultado.Text = "O Numero "+numero+" ao quadrado é "+numero+ quadrado.ToString();
                tbxnum.Focus();
                tbxnum.SelectAll();
            }
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btncalcular.PerformClick();
            }
        }
    }
}
