using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParOuImpar
{
    public partial class frmParOuImpar : Form
    {
        public frmParOuImpar()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var valor = int.Parse(txtValor.Text);

            //txtValor.Text = (valor % 2).ToString();
            if ((valor % 2) == 0)
            {
                MessageBox.Show("Par");
            }
            else
                MessageBox.Show("Ímpar");
            
        }
        
    }
}
