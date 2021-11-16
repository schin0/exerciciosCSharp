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
    public partial class exercicio6 : Form
    {
        string texto, item;
        int tamanho, i, posicao;

        public exercicio6()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adicionar()
        {
            texto = txtPalavra.Text;

            lstEsquerda.Items.Add(texto);
        }

        private void letraALetra()
        {
            texto = txtPalavra.Text;
            tamanho = texto.Length;

            for (i = 0; i < tamanho; i++)
            {
                lstDireita.Items.Add(texto[i]);
            }
        }

        private void removerEsquerda()
        {
            posicao = lstEsquerda.SelectedIndex;
            lstEsquerda.Items.RemoveAt(posicao);
        }

        private void removerDireita()
        {
            posicao = lstDireita.SelectedIndex;
            lstDireita.Items.RemoveAt(posicao);
        }

        private void OrdenarEsquerda()
        {
            lstEsquerda.Sorted = true;
        }

        private void OrdenarDireita()
        {
            lstDireita.Sorted = true;
        }

        private void MoverPEsquerda()
        {
            item = lstDireita.Text;

            lstEsquerda.Items.Add(item);
            removerDireita();
        }
        private void MoverPDireita()
        {
            item = lstEsquerda.Text;

            lstDireita.Items.Add(item);
            removerEsquerda();
        }

        private void tudoPDireita()
        {
            lstDireita.Items.AddRange(lstEsquerda.Items);
            lstEsquerda.Items.Clear();
        }

        private void tudoPEsquerda()
        {
            lstEsquerda.Items.AddRange(lstDireita.Items);
            lstDireita.Items.Clear();
        }

        private void Limpar()
        {
            lstDireita.Items.Clear();
            lstEsquerda.Items.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void btnRemoverEsq_Click(object sender, EventArgs e)
        {
            removerEsquerda();
        }

        private void btnOrdenarEsq_Click(object sender, EventArgs e)
        {
            OrdenarEsquerda();
        }

        private void btnOrdenarDir_Click(object sender, EventArgs e)
        {
            OrdenarDireita();
        }

        private void btnEnviarEsq_Click(object sender, EventArgs e)
        {
            MoverPEsquerda();
        }

        private void btnTudoDir_Click(object sender, EventArgs e)
        {
            tudoPDireita();
        }

        private void btnTudoEsq_Click(object sender, EventArgs e)
        {
            tudoPEsquerda();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnEnviarDir_Click(object sender, EventArgs e)
        {
            MoverPDireita();
        }

        private void btnRemoverDir_Click(object sender, EventArgs e)
        {
            removerDireita();
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            letraALetra();
        }
    }
}
