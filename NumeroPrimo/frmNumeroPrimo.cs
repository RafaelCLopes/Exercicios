using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPrimo
{
    public partial class frmNumeroPrimo : Form
    {
        public frmNumeroPrimo()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            int i;
            int valor = int.Parse(txtValor.Text);
            for (i = 2; i < valor - 1; i++) //looping
            {
                if ((valor % i) == 0)
                {

                    MessageBox.Show("Não é Primo");
                    break;
                }

                else
                {
                    MessageBox.Show("É Primo");
                    break;
                }
            }

        }
    }
}
