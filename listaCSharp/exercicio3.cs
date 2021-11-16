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
    public partial class exercicio3 : Form
    {
        int num, i;
        public exercicio3()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int x = 0, y = 1, z;

            num = int.Parse(txtNum.Text);
            lstResultado.Items.Add(x);
            cmbResultado.Items.Add(x);
            lstResultado.Items.Add(y);
            cmbResultado.Items.Add(y);

            for (i = 2; i < num; i++)
            {
                z = x + y;
                lstResultado.Items.Add(z);
                cmbResultado.Items.Add(z);
                x = y;
                y = z;
            }
        }
    }
}
