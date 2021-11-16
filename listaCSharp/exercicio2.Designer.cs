namespace listaCSharp
{
    partial class exercicio2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstPares = new System.Windows.Forms.ListBox();
            this.lstImpares = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultQtde = new System.Windows.Forms.Label();
            this.lblResultSomaTotal = new System.Windows.Forms.Label();
            this.lblResultQtdePares = new System.Windows.Forms.Label();
            this.lblResultSomaPares = new System.Windows.Forms.Label();
            this.lblResultQtdeImpares = new System.Windows.Forms.Label();
            this.lblResultSomaImpares = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Salmon;
            this.btnFechar.Location = new System.Drawing.Point(200, 388);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(109, 34);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(104, 29);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionar.Location = new System.Drawing.Point(242, 25);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(109, 26);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(380, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 26);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de números:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soma total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultSomaPares);
            this.groupBox1.Controls.Add(this.lblResultQtdePares);
            this.groupBox1.Controls.Add(this.lstPares);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 201);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pares";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultSomaImpares);
            this.groupBox2.Controls.Add(this.lblResultQtdeImpares);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstImpares);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(271, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 201);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ímpares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantidade de pares:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade de ímpares:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Soma de pares:";
            // 
            // lstPares
            // 
            this.lstPares.FormattingEnabled = true;
            this.lstPares.ItemHeight = 16;
            this.lstPares.Location = new System.Drawing.Point(9, 101);
            this.lstPares.Name = "lstPares";
            this.lstPares.Size = new System.Drawing.Size(196, 84);
            this.lstPares.TabIndex = 14;
            // 
            // lstImpares
            // 
            this.lstImpares.FormattingEnabled = true;
            this.lstImpares.ItemHeight = 16;
            this.lstImpares.Location = new System.Drawing.Point(9, 101);
            this.lstImpares.Name = "lstImpares";
            this.lstImpares.Size = new System.Drawing.Size(209, 84);
            this.lstImpares.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Soma de ímpares:";
            // 
            // lblResultQtde
            // 
            this.lblResultQtde.AutoSize = true;
            this.lblResultQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultQtde.Location = new System.Drawing.Point(183, 97);
            this.lblResultQtde.Name = "lblResultQtde";
            this.lblResultQtde.Size = new System.Drawing.Size(20, 17);
            this.lblResultQtde.TabIndex = 12;
            this.lblResultQtde.Text = "...";
            // 
            // lblResultSomaTotal
            // 
            this.lblResultSomaTotal.AutoSize = true;
            this.lblResultSomaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSomaTotal.Location = new System.Drawing.Point(402, 97);
            this.lblResultSomaTotal.Name = "lblResultSomaTotal";
            this.lblResultSomaTotal.Size = new System.Drawing.Size(20, 17);
            this.lblResultSomaTotal.TabIndex = 13;
            this.lblResultSomaTotal.Text = "...";
            // 
            // lblResultQtdePares
            // 
            this.lblResultQtdePares.AutoSize = true;
            this.lblResultQtdePares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultQtdePares.Location = new System.Drawing.Point(169, 26);
            this.lblResultQtdePares.Name = "lblResultQtdePares";
            this.lblResultQtdePares.Size = new System.Drawing.Size(20, 17);
            this.lblResultQtdePares.TabIndex = 14;
            this.lblResultQtdePares.Text = "...";
            // 
            // lblResultSomaPares
            // 
            this.lblResultSomaPares.AutoSize = true;
            this.lblResultSomaPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSomaPares.Location = new System.Drawing.Point(168, 57);
            this.lblResultSomaPares.Name = "lblResultSomaPares";
            this.lblResultSomaPares.Size = new System.Drawing.Size(20, 17);
            this.lblResultSomaPares.TabIndex = 15;
            this.lblResultSomaPares.Text = "...";
            // 
            // lblResultQtdeImpares
            // 
            this.lblResultQtdeImpares.AutoSize = true;
            this.lblResultQtdeImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultQtdeImpares.Location = new System.Drawing.Point(172, 26);
            this.lblResultQtdeImpares.Name = "lblResultQtdeImpares";
            this.lblResultQtdeImpares.Size = new System.Drawing.Size(20, 17);
            this.lblResultQtdeImpares.TabIndex = 16;
            this.lblResultQtdeImpares.Text = "...";
            // 
            // lblResultSomaImpares
            // 
            this.lblResultSomaImpares.AutoSize = true;
            this.lblResultSomaImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSomaImpares.Location = new System.Drawing.Point(172, 57);
            this.lblResultSomaImpares.Name = "lblResultSomaImpares";
            this.lblResultSomaImpares.Size = new System.Drawing.Size(20, 17);
            this.lblResultSomaImpares.TabIndex = 17;
            this.lblResultSomaImpares.Text = "...";
            // 
            // exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 443);
            this.Controls.Add(this.lblResultSomaTotal);
            this.Controls.Add(this.lblResultQtde);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFechar);
            this.Name = "exercicio2";
            this.Text = "Exercício 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstImpares;
        private System.Windows.Forms.Label lblResultSomaPares;
        private System.Windows.Forms.Label lblResultQtdePares;
        private System.Windows.Forms.Label lblResultSomaImpares;
        private System.Windows.Forms.Label lblResultQtdeImpares;
        private System.Windows.Forms.Label lblResultQtde;
        private System.Windows.Forms.Label lblResultSomaTotal;
    }
}