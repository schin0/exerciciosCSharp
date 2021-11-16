namespace listaCSharp
{
    partial class exercicio7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResultInvertida = new System.Windows.Forms.Label();
            this.lblResultEspacos = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultA = new System.Windows.Forms.Label();
            this.lblResultE = new System.Windows.Forms.Label();
            this.lblResultI = new System.Windows.Forms.Label();
            this.lblResultO = new System.Windows.Forms.Label();
            this.lblResultU = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstResultLinha = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstResultPalavra = new System.Windows.Forms.ListBox();
            this.btnTamanho = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblResultTamanho = new System.Windows.Forms.Label();
            this.btnInverter = new System.Windows.Forms.Button();
            this.btnVogais = new System.Windows.Forms.Button();
            this.btnQuebraLinha = new System.Windows.Forms.Button();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.btnChamarTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnQuebraPalavra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Salmon;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFechar.Location = new System.Drawing.Point(607, 433);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(118, 30);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFrase);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frase";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(6, 22);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(519, 23);
            this.txtFrase.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultInvertida);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frase Invertida";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResultEspacos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 63);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suprimir espaços";
            // 
            // lblResultInvertida
            // 
            this.lblResultInvertida.AutoSize = true;
            this.lblResultInvertida.Location = new System.Drawing.Point(6, 29);
            this.lblResultInvertida.Name = "lblResultInvertida";
            this.lblResultInvertida.Size = new System.Drawing.Size(0, 17);
            this.lblResultInvertida.TabIndex = 10;
            // 
            // lblResultEspacos
            // 
            this.lblResultEspacos.AutoSize = true;
            this.lblResultEspacos.Location = new System.Drawing.Point(6, 31);
            this.lblResultEspacos.Name = "lblResultEspacos";
            this.lblResultEspacos.Size = new System.Drawing.Size(0, 17);
            this.lblResultEspacos.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblResultU);
            this.groupBox4.Controls.Add(this.lblResultO);
            this.groupBox4.Controls.Add(this.lblResultI);
            this.groupBox4.Controls.Add(this.lblResultE);
            this.groupBox4.Controls.Add(this.lblResultA);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 221);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total de vogais:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "E:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "I:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "O:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "U:";
            // 
            // lblResultA
            // 
            this.lblResultA.AutoSize = true;
            this.lblResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultA.Location = new System.Drawing.Point(90, 30);
            this.lblResultA.Name = "lblResultA";
            this.lblResultA.Size = new System.Drawing.Size(21, 20);
            this.lblResultA.TabIndex = 12;
            this.lblResultA.Text = "...";
            // 
            // lblResultE
            // 
            this.lblResultE.AutoSize = true;
            this.lblResultE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultE.Location = new System.Drawing.Point(90, 67);
            this.lblResultE.Name = "lblResultE";
            this.lblResultE.Size = new System.Drawing.Size(21, 20);
            this.lblResultE.TabIndex = 15;
            this.lblResultE.Text = "...";
            // 
            // lblResultI
            // 
            this.lblResultI.AutoSize = true;
            this.lblResultI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultI.Location = new System.Drawing.Point(90, 105);
            this.lblResultI.Name = "lblResultI";
            this.lblResultI.Size = new System.Drawing.Size(21, 20);
            this.lblResultI.TabIndex = 16;
            this.lblResultI.Text = "...";
            // 
            // lblResultO
            // 
            this.lblResultO.AutoSize = true;
            this.lblResultO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultO.Location = new System.Drawing.Point(90, 146);
            this.lblResultO.Name = "lblResultO";
            this.lblResultO.Size = new System.Drawing.Size(21, 20);
            this.lblResultO.TabIndex = 17;
            this.lblResultO.Text = "...";
            // 
            // lblResultU
            // 
            this.lblResultU.AutoSize = true;
            this.lblResultU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultU.Location = new System.Drawing.Point(90, 180);
            this.lblResultU.Name = "lblResultU";
            this.lblResultU.Size = new System.Drawing.Size(21, 20);
            this.lblResultU.TabIndex = 18;
            this.lblResultU.Text = "...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstResultLinha);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(188, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 221);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quebra por linha:";
            // 
            // lstResultLinha
            // 
            this.lstResultLinha.FormattingEnabled = true;
            this.lstResultLinha.ItemHeight = 16;
            this.lstResultLinha.Location = new System.Drawing.Point(6, 22);
            this.lstResultLinha.Name = "lstResultLinha";
            this.lstResultLinha.Size = new System.Drawing.Size(145, 180);
            this.lstResultLinha.TabIndex = 20;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstResultPalavra);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(364, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 221);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quebra por palavra:";
            // 
            // lstResultPalavra
            // 
            this.lstResultPalavra.FormattingEnabled = true;
            this.lstResultPalavra.ItemHeight = 16;
            this.lstResultPalavra.Location = new System.Drawing.Point(6, 22);
            this.lstResultPalavra.Name = "lstResultPalavra";
            this.lstResultPalavra.Size = new System.Drawing.Size(145, 180);
            this.lstResultPalavra.TabIndex = 20;
            // 
            // btnTamanho
            // 
            this.btnTamanho.BackColor = System.Drawing.Color.DarkGray;
            this.btnTamanho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTamanho.Location = new System.Drawing.Point(607, 90);
            this.btnTamanho.Name = "btnTamanho";
            this.btnTamanho.Size = new System.Drawing.Size(118, 30);
            this.btnTamanho.TabIndex = 23;
            this.btnTamanho.Text = "Tamanho";
            this.btnTamanho.UseVisualStyleBackColor = false;
            this.btnTamanho.Click += new System.EventHandler(this.btnTamanho_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblResultTamanho);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(584, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(170, 63);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Total de caracteres:";
            // 
            // lblResultTamanho
            // 
            this.lblResultTamanho.AutoSize = true;
            this.lblResultTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTamanho.Location = new System.Drawing.Point(70, 25);
            this.lblResultTamanho.Name = "lblResultTamanho";
            this.lblResultTamanho.Size = new System.Drawing.Size(21, 20);
            this.lblResultTamanho.TabIndex = 10;
            this.lblResultTamanho.Text = "...";
            // 
            // btnInverter
            // 
            this.btnInverter.BackColor = System.Drawing.Color.DarkGray;
            this.btnInverter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInverter.Location = new System.Drawing.Point(607, 126);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(118, 30);
            this.btnInverter.TabIndex = 24;
            this.btnInverter.Text = "Inverter";
            this.btnInverter.UseVisualStyleBackColor = false;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // btnVogais
            // 
            this.btnVogais.BackColor = System.Drawing.Color.DarkGray;
            this.btnVogais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVogais.Location = new System.Drawing.Point(607, 162);
            this.btnVogais.Name = "btnVogais";
            this.btnVogais.Size = new System.Drawing.Size(118, 30);
            this.btnVogais.TabIndex = 25;
            this.btnVogais.Text = "Vogais";
            this.btnVogais.UseVisualStyleBackColor = false;
            this.btnVogais.Click += new System.EventHandler(this.btnVogais_Click);
            // 
            // btnQuebraLinha
            // 
            this.btnQuebraLinha.BackColor = System.Drawing.Color.DarkGray;
            this.btnQuebraLinha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuebraLinha.Location = new System.Drawing.Point(607, 270);
            this.btnQuebraLinha.Name = "btnQuebraLinha";
            this.btnQuebraLinha.Size = new System.Drawing.Size(118, 30);
            this.btnQuebraLinha.TabIndex = 28;
            this.btnQuebraLinha.Text = "Quebrar por linha";
            this.btnQuebraLinha.UseVisualStyleBackColor = false;
            this.btnQuebraLinha.Click += new System.EventHandler(this.btnQuebraLinha_Click);
            // 
            // btnEspacos
            // 
            this.btnEspacos.BackColor = System.Drawing.Color.DarkGray;
            this.btnEspacos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEspacos.Location = new System.Drawing.Point(607, 234);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(118, 30);
            this.btnEspacos.TabIndex = 27;
            this.btnEspacos.Text = "Retirar espaços";
            this.btnEspacos.UseVisualStyleBackColor = false;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.BackColor = System.Drawing.Color.DarkGray;
            this.btnPalindrome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPalindrome.Location = new System.Drawing.Point(607, 198);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(118, 30);
            this.btnPalindrome.TabIndex = 26;
            this.btnPalindrome.Text = "Palíndrome";
            this.btnPalindrome.UseVisualStyleBackColor = false;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // btnChamarTodos
            // 
            this.btnChamarTodos.BackColor = System.Drawing.Color.DarkGray;
            this.btnChamarTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChamarTodos.Location = new System.Drawing.Point(607, 378);
            this.btnChamarTodos.Name = "btnChamarTodos";
            this.btnChamarTodos.Size = new System.Drawing.Size(118, 30);
            this.btnChamarTodos.TabIndex = 31;
            this.btnChamarTodos.Text = "Todos";
            this.btnChamarTodos.UseVisualStyleBackColor = false;
            this.btnChamarTodos.Click += new System.EventHandler(this.btnChamarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(607, 342);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 30);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnQuebraPalavra
            // 
            this.btnQuebraPalavra.BackColor = System.Drawing.Color.DarkGray;
            this.btnQuebraPalavra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuebraPalavra.Location = new System.Drawing.Point(607, 306);
            this.btnQuebraPalavra.Name = "btnQuebraPalavra";
            this.btnQuebraPalavra.Size = new System.Drawing.Size(118, 30);
            this.btnQuebraPalavra.TabIndex = 29;
            this.btnQuebraPalavra.Text = "Quebrar por palavra";
            this.btnQuebraPalavra.UseVisualStyleBackColor = false;
            this.btnQuebraPalavra.Click += new System.EventHandler(this.btnQuebraPalavra_Click);
            // 
            // exercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 495);
            this.Controls.Add(this.btnChamarTodos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnQuebraPalavra);
            this.Controls.Add(this.btnQuebraLinha);
            this.Controls.Add(this.btnEspacos);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btnVogais);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnTamanho);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Name = "exercicio7";
            this.Text = "Exercício 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultInvertida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResultEspacos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblResultU;
        private System.Windows.Forms.Label lblResultO;
        private System.Windows.Forms.Label lblResultI;
        private System.Windows.Forms.Label lblResultE;
        private System.Windows.Forms.Label lblResultA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstResultLinha;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstResultPalavra;
        private System.Windows.Forms.Button btnTamanho;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblResultTamanho;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnVogais;
        private System.Windows.Forms.Button btnQuebraLinha;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.Button btnChamarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnQuebraPalavra;
    }
}