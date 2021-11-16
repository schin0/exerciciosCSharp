using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaCSharp
{
    public partial class exercicio4 : Form
    {
        int num, i, resultado;
        String result;

        public exercicio4()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtNum.Text);
            i = num;

            while (i != 1)
            {
                i--;
                lstResultado.Items.Add(" x " + i);
                cmbResultado.Items.Add(" x " + i);
                resultado = num * i;
                num = resultado;
                lstResultado.Items.Add(" = " + resultado);
                cmbResultado.Items.Add(" = " + resultado);
            }

            result = Convert.ToString(resultado);
            MessageBox.Show("O resultado é: \n" + result);
        }
    }
}
