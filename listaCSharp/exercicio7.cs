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
    public partial class exercicio7 : Form
    {
        string texto, txtSemEspaco, texto2;
        int tamanho, qtdA, qtdE, qtdI, qtdO, qtdU, i;

        public exercicio7()
        {
            InitializeComponent();
        }

        private void btnVogais_Click(object sender, EventArgs e)
        {
            contarVogais();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            verificarPalindrome();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            suprimirEspacos();
        }

        private void verificarTamanho()
        {
            texto = txtFrase.Text;
            tamanho = texto.Length;

            lblResultTamanho.Text = Convert.ToString(tamanho);
        }

        private void btnQuebraLinha_Click(object sender, EventArgs e)
        {
            quebrarPorLinha();
        }

        private void btnQuebraPalavra_Click(object sender, EventArgs e)
        {
            quebrarPorPalavra();
        }

        private void Limpar()
        {
            lblResultInvertida.Text = "";
            lblResultA.Text = "...";
            lblResultE.Text = "...";
            lblResultI.Text = "...";
            lblResultO.Text = "...";
            lblResultU.Text = "...";
            lblResultEspacos.Text = "";
            lstResultLinha.Items.Clear();
            lstResultPalavra.Items.Clear();
            lblResultTamanho.Text = "...";
            txtFrase.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnChamarTodos_Click(object sender, EventArgs e)
        {
            verificarTamanho();
            Inverter();
            contarVogais();
            verificarPalindrome();
            suprimirEspacos();
            quebrarPorLinha();
            quebrarPorPalavra();
        }

        private void Inverter()
        {
            texto = txtFrase.Text;
            string txtInvertido = new string(texto.Reverse().ToArray());

            lblResultInvertida.Text = txtInvertido;
        }

        private void contarVogais()
        {
            texto = txtFrase.Text;
            tamanho = texto.Length;
            qtdA = 0;
            qtdE = 0;
            qtdI = 0;
            qtdO = 0;
            qtdU = 0;

            for (i = 0; i < tamanho; i++) { 
                if(texto[i] == 'a' || texto[i] == 'A' || 
                    texto[i] == 'â' ||texto[i] == 'Â' || 
                    texto[i] == 'ã' || texto[i] == 'Ã' ||
                    texto[i] == 'á' || texto[i] == 'Á' ||
                    texto[i] == 'à' || texto[i] == 'À'
                    ) 
                { 
                    qtdA++;
                }

                if(texto[i] == 'e' || texto[i] == 'E' ||
                    texto[i] == 'ê' || texto[i] == 'Ê' ||
                    texto[i] == 'é' || texto[i] == 'É' ||
                    texto[i] == 'è' || texto[i] == 'È') 
                {
                    qtdE++;
                }

                if(texto[i] == 'i' || texto[i] == 'I' ||
                    texto[i] == 'î' || texto[i] == 'Î' ||
                    texto[i] == 'í' || texto[i] == 'Í' ||
                    texto[i] == 'ì' || texto[i] == 'Ì') 
                {
                    qtdI++;
                }

                if(texto[i] == 'o' || texto[i] == 'O' ||
                    texto[i] == 'ô' || texto[i] == 'Ô' ||
                    texto[i] == 'õ' || texto[i] == 'Õ' ||
                    texto[i] == 'ó' || texto[i] == 'Ó' ||
                    texto[i] == 'ò' || texto[i] == 'Ò')
                {
                    qtdO++;
                }

                if (texto[i] == 'u' || texto[i] == 'U' ||
                    texto[i] == 'û' || texto[i] == 'Û' ||
                    texto[i] == 'ú' || texto[i] == 'Ú' ||
                    texto[i] == 'ù' || texto[i] == 'Ù')
                {
                    qtdU++;
                }

                lblResultA.Text = Convert.ToString(qtdA);
                lblResultE.Text = Convert.ToString(qtdE);
                lblResultI.Text = Convert.ToString(qtdI);
                lblResultO.Text = Convert.ToString(qtdO);
                lblResultU.Text = Convert.ToString(qtdU);
            }
        }

        private void verificarPalindrome()
        {
            texto = txtFrase.Text;
            string txtInvertido = new string(texto.Reverse().ToArray());

            if (texto == txtInvertido)
            {
                MessageBox.Show("A frase/palavra " + texto + " é uma palavra palíndrome.");
            } else
            {
                MessageBox.Show("A frase/palavra " + texto + " não é uma palavra palíndrome.");
            }
        }

        private void suprimirEspacos()
        {
            texto = txtFrase.Text;
            txtSemEspaco = texto.Replace(" ", "");

            lblResultEspacos.Text = txtSemEspaco;
        }

        private void quebrarPorLinha()
        {
            texto = txtFrase.Text;
            tamanho = texto.Length;

            for(i = 0; i < tamanho; i++)
            {
                lstResultLinha.Items.Add(texto[i]);
            }
        }

        private void quebrarPorPalavra()
        {
            texto = txtFrase.Text;
            tamanho = texto.Length;
            texto2 = "";

            for (i = 0; i < tamanho; i++)
            {
                if(texto[i] != ' ')
                {
                    texto2 += texto[i];
                } else
                {
                    lstResultPalavra.Items.Add(texto2);
                    texto2 = "";
                }
            }

            if (texto2 != "")
            {
                lstResultPalavra.Items.Add(texto2);
                texto2 = "";
            }
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            verificarTamanho();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            Inverter();
        }
    }
}
