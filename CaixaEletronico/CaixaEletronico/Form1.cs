using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double saldo = 100;
            double valor = Double.Parse(txtValor.Text);
            if (valor <= saldo)
            {
                saldo = saldo - valor;
                MessageBox.Show("Saque realizado com Sucesso");

            }
            else
                MessageBox.Show("Saldo Insuficiente");
               }
    }
}
