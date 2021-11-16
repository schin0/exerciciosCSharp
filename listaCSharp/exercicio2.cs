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
    public partial class exercicio2 : Form
    {
        double num, soma, somaPar, somaImpar;
        int qtdNum, qtdNumPar, qtdNumImpar;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            /* ===== Botão para limpar ===== */
            num = 0;
            soma = 0;
            somaPar = 0;
            somaImpar = 0;
            qtdNum = 0;
            qtdNumPar = 0;
            qtdNumImpar = 0;
            txtNum.Text = "";
            
            lblResultQtde.Text = "";
            lblResultQtdeImpares.Text = "";
            lblResultQtdePares.Text = "";
            lblResultSomaPares.Text = "";
            lblResultSomaImpares.Text = "";
            lblResultQtde.Text = "";
            lblResultSomaTotal.Text = "";
            
            lstPares.Items.Clear();
            lstImpares.Items.Clear();
        }

        public exercicio2()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            num = Double.Parse(txtNum.Text);
            qtdNum++;
            lblResultQtde.Text = Convert.ToString(qtdNum);
            soma += num;
            lblResultSomaTotal.Text = Convert.ToString(soma);

            if (num % 2 == 0)
            {
                qtdNumPar++;
                lblResultQtdePares.Text = Convert.ToString(qtdNumPar);
                somaPar += num;
                lblResultSomaPares.Text = Convert.ToString(somaPar);
                lstPares.Items.Add(num + "\n");
            }
            else
            {
                qtdNumImpar++;
                lblResultQtdeImpares.Text = Convert.ToString(qtdNumImpar);
                somaImpar += num;
                lblResultSomaImpares.Text = Convert.ToString(somaImpar);
                lstImpares.Items.Add(num + "\n");
            }
        }
    }
}
