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
    public partial class formExercicios : Form
    {
        public formExercicios()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio1 = new exercicio1();
            Exercicio1.ShowDialog();
            this.Visible = true;
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio2 = new exercicio2();
            Exercicio2.ShowDialog();
            this.Visible = true;
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio3 = new exercicio3();
            Exercicio3.ShowDialog();
            this.Visible = true;
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio4 = new exercicio4();
            Exercicio4.ShowDialog();
            this.Visible = true;
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio5 = new exercicio5();
            Exercicio5.ShowDialog();
            this.Visible = true;
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio6 = new exercicio6();
            Exercicio6.ShowDialog();
            this.Visible = true;
        }

        private void exercício7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio7 = new exercicio7();
            Exercicio7.ShowDialog();
            this.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExerc1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio1 = new exercicio1();
            Exercicio1.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio5 = new exercicio5();
            Exercicio5.ShowDialog();
            this.Visible = true;
        }

        private void btnExerc2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio2 = new exercicio2();
            Exercicio2.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio4 = new exercicio4();
            Exercicio4.ShowDialog();
            this.Visible = true;
        }

        private void btnExerc3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio3 = new exercicio3();
            Exercicio3.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio6 = new exercicio6();
            Exercicio6.ShowDialog();
            this.Visible = true;
        }

        private void btnExerc7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Exercicio7 = new exercicio7();
            Exercicio7.ShowDialog();
            this.Visible = true;
        }
    }
}
