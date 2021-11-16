namespace listaCSharp
{
    partial class exercicio6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstEsquerda = new System.Windows.Forms.ListBox();
            this.lstDireita = new System.Windows.Forms.ListBox();
            this.btnLetra = new System.Windows.Forms.Button();
            this.btnOrdenarEsq = new System.Windows.Forms.Button();
            this.btnRemoverEsq = new System.Windows.Forms.Button();
            this.btnRemoverDir = new System.Windows.Forms.Button();
            this.btnOrdenarDir = new System.Windows.Forms.Button();
            this.btnEnviarDir = new System.Windows.Forms.Button();
            this.btnTudoDir = new System.Windows.Forms.Button();
            this.btnTudoEsq = new System.Windows.Forms.Button();
            this.btnEnviarEsq = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Salmon;
            this.btnFechar.Location = new System.Drawing.Point(232, 425);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 32);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palavra:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(92, 22);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(145, 23);
            this.txtPalavra.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar.Location = new System.Drawing.Point(257, 18);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 30);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstEsquerda
            // 
            this.lstEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEsquerda.FormattingEnabled = true;
            this.lstEsquerda.ItemHeight = 16;
            this.lstEsquerda.Location = new System.Drawing.Point(8, 131);
            this.lstEsquerda.Name = "lstEsquerda";
            this.lstEsquerda.Size = new System.Drawing.Size(222, 276);
            this.lstEsquerda.TabIndex = 25;
            // 
            // lstDireita
            // 
            this.lstDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDireita.FormattingEnabled = true;
            this.lstDireita.ItemHeight = 16;
            this.lstDireita.Location = new System.Drawing.Point(342, 131);
            this.lstDireita.Name = "lstDireita";
            this.lstDireita.Size = new System.Drawing.Size(222, 276);
            this.lstDireita.TabIndex = 26;
            // 
            // btnLetra
            // 
            this.btnLetra.BackColor = System.Drawing.Color.LightGreen;
            this.btnLetra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLetra.Location = new System.Drawing.Point(342, 18);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(92, 30);
            this.btnLetra.TabIndex = 27;
            this.btnLetra.Text = "Letra a letra";
            this.btnLetra.UseVisualStyleBackColor = false;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnOrdenarEsq
            // 
            this.btnOrdenarEsq.BackColor = System.Drawing.Color.LightBlue;
            this.btnOrdenarEsq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrdenarEsq.Location = new System.Drawing.Point(8, 78);
            this.btnOrdenarEsq.Name = "btnOrdenarEsq";
            this.btnOrdenarEsq.Size = new System.Drawing.Size(85, 30);
            this.btnOrdenarEsq.TabIndex = 28;
            this.btnOrdenarEsq.Text = "Ordenar";
            this.btnOrdenarEsq.UseVisualStyleBackColor = false;
            this.btnOrdenarEsq.Click += new System.EventHandler(this.btnOrdenarEsq_Click);
            // 
            // btnRemoverEsq
            // 
            this.btnRemoverEsq.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemoverEsq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoverEsq.Location = new System.Drawing.Point(145, 78);
            this.btnRemoverEsq.Name = "btnRemoverEsq";
            this.btnRemoverEsq.Size = new System.Drawing.Size(85, 30);
            this.btnRemoverEsq.TabIndex = 29;
            this.btnRemoverEsq.Text = "Remover";
            this.btnRemoverEsq.UseVisualStyleBackColor = false;
            this.btnRemoverEsq.Click += new System.EventHandler(this.btnRemoverEsq_Click);
            // 
            // btnRemoverDir
            // 
            this.btnRemoverDir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemoverDir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoverDir.Location = new System.Drawing.Point(479, 78);
            this.btnRemoverDir.Name = "btnRemoverDir";
            this.btnRemoverDir.Size = new System.Drawing.Size(85, 30);
            this.btnRemoverDir.TabIndex = 31;
            this.btnRemoverDir.Text = "Remover";
            this.btnRemoverDir.UseVisualStyleBackColor = false;
            this.btnRemoverDir.Click += new System.EventHandler(this.btnRemoverDir_Click);
            // 
            // btnOrdenarDir
            // 
            this.btnOrdenarDir.BackColor = System.Drawing.Color.LightBlue;
            this.btnOrdenarDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrdenarDir.Location = new System.Drawing.Point(342, 78);
            this.btnOrdenarDir.Name = "btnOrdenarDir";
            this.btnOrdenarDir.Size = new System.Drawing.Size(85, 30);
            this.btnOrdenarDir.TabIndex = 30;
            this.btnOrdenarDir.Text = "Ordenar";
            this.btnOrdenarDir.UseVisualStyleBackColor = false;
            this.btnOrdenarDir.Click += new System.EventHandler(this.btnOrdenarDir_Click);
            // 
            // btnEnviarDir
            // 
            this.btnEnviarDir.BackColor = System.Drawing.Color.LightBlue;
            this.btnEnviarDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviarDir.Location = new System.Drawing.Point(257, 152);
            this.btnEnviarDir.Name = "btnEnviarDir";
            this.btnEnviarDir.Size = new System.Drawing.Size(60, 30);
            this.btnEnviarDir.TabIndex = 32;
            this.btnEnviarDir.Text = ">";
            this.btnEnviarDir.UseVisualStyleBackColor = false;
            this.btnEnviarDir.Click += new System.EventHandler(this.btnEnviarDir_Click);
            // 
            // btnTudoDir
            // 
            this.btnTudoDir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTudoDir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTudoDir.Location = new System.Drawing.Point(257, 200);
            this.btnTudoDir.Name = "btnTudoDir";
            this.btnTudoDir.Size = new System.Drawing.Size(60, 30);
            this.btnTudoDir.TabIndex = 33;
            this.btnTudoDir.Text = ">>";
            this.btnTudoDir.UseVisualStyleBackColor = false;
            this.btnTudoDir.Click += new System.EventHandler(this.btnTudoDir_Click);
            // 
            // btnTudoEsq
            // 
            this.btnTudoEsq.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTudoEsq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTudoEsq.Location = new System.Drawing.Point(257, 350);
            this.btnTudoEsq.Name = "btnTudoEsq";
            this.btnTudoEsq.Size = new System.Drawing.Size(60, 30);
            this.btnTudoEsq.TabIndex = 35;
            this.btnTudoEsq.Text = "<<";
            this.btnTudoEsq.UseVisualStyleBackColor = false;
            this.btnTudoEsq.Click += new System.EventHandler(this.btnTudoEsq_Click);
            // 
            // btnEnviarEsq
            // 
            this.btnEnviarEsq.BackColor = System.Drawing.Color.LightBlue;
            this.btnEnviarEsq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviarEsq.Location = new System.Drawing.Point(257, 302);
            this.btnEnviarEsq.Name = "btnEnviarEsq";
            this.btnEnviarEsq.Size = new System.Drawing.Size(60, 30);
            this.btnEnviarEsq.TabIndex = 34;
            this.btnEnviarEsq.Text = "<";
            this.btnEnviarEsq.UseVisualStyleBackColor = false;
            this.btnEnviarEsq.Click += new System.EventHandler(this.btnEnviarEsq_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(489, 18);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // exercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 469);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTudoEsq);
            this.Controls.Add(this.btnEnviarEsq);
            this.Controls.Add(this.btnTudoDir);
            this.Controls.Add(this.btnEnviarDir);
            this.Controls.Add(this.btnRemoverDir);
            this.Controls.Add(this.btnOrdenarDir);
            this.Controls.Add(this.btnRemoverEsq);
            this.Controls.Add(this.btnOrdenarEsq);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.lstDireita);
            this.Controls.Add(this.lstEsquerda);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Name = "exercicio6";
            this.Text = "Exercício 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lstEsquerda;
        private System.Windows.Forms.ListBox lstDireita;
        private System.Windows.Forms.Button btnLetra;
        private System.Windows.Forms.Button btnOrdenarEsq;
        private System.Windows.Forms.Button btnRemoverEsq;
        private System.Windows.Forms.Button btnRemoverDir;
        private System.Windows.Forms.Button btnOrdenarDir;
        private System.Windows.Forms.Button btnEnviarDir;
        private System.Windows.Forms.Button btnTudoDir;
        private System.Windows.Forms.Button btnTudoEsq;
        private System.Windows.Forms.Button btnEnviarEsq;
        private System.Windows.Forms.Button btnLimpar;
    }
}