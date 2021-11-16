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
    public partial class exercicio1 : Form
    {
        int i;
        double num, resultado;

        public exercicio1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            num = Double.Parse(txtNum.Text);
            lstResultado.Items.Clear();
            cmbResult.Items.Clear();

            for (i = 0; i <= 10; i++)
            {
                resultado = num * i;
                lstResultado.Items.Add(num + " x " + i + " = " + resultado);
                cmbResult.Items.Add(num + " x " + i + " = " + resultado);
            }

            txtNum.Text = "";
        }
    }
}
