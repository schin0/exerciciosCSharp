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
    public partial class exercicio5 : Form
    {
        int numInicial, numFinal, tabuada, i, j, result;
        public exercicio5()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            numInicial = int.Parse(txtTabuadaInicial.Text);
            numFinal = int.Parse(txtTabuadaFinal.Text);
            tabuada = numInicial;

            if (numFinal < numInicial)
            {
                lstResultado.Items.Clear();

                MessageBox.Show("O número inicial " + numInicial + " é maior que o número final " + numFinal +
                    ".");

                while (numFinal <= numInicial)
                {
                    i = 0;
                    lstResultado.Items.Add("======================================");
                    lstResultado.Items.Add("Tabuada do " + numInicial + ":");
                    lstResultado.Items.Add("======================================");

                    while (i <= 10)
                    {
                        result = numInicial * i;
                        lstResultado.Items.Add(numInicial + " x " + i + " = " + result);
                        i++;
                    }

                    numInicial--;
                }
            }
            else if (numFinal > numInicial) {
                {
                    lstResultado.Items.Clear();

                    while (tabuada <= numFinal)
                    {
                        i = 0;
                        lstResultado.Items.Add("======================================");
                        lstResultado.Items.Add("Tabuada do " + tabuada + ":");
                        lstResultado.Items.Add("======================================");

                        while (i <= 10)
                        {
                            result = tabuada * i;
                            lstResultado.Items.Add(tabuada + " x " + i + " = " + result);
                            i++;
                        }

                        tabuada++;
                    }
                }
            }
            else {
                MessageBox.Show("Insira dois valores diferentes.");
            }
        }
    }
}
