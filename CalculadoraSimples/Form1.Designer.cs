using System;

namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDigitePrimeiroNumero = new System.Windows.Forms.Label();
            this.lblDigiteSegundoNumero = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtDigitePrimeiroNumero = new System.Windows.Forms.TextBox();
            this.txtDigiteSegundoNumero = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigitePrimeiroNumero
            // 
            this.lblDigitePrimeiroNumero.AutoSize = true;
            this.lblDigitePrimeiroNumero.Location = new System.Drawing.Point(67, 54);
            this.lblDigitePrimeiroNumero.Name = "lblDigitePrimeiroNumero";
            this.lblDigitePrimeiroNumero.Size = new System.Drawing.Size(123, 13);
            this.lblDigitePrimeiroNumero.TabIndex = 0;
            this.lblDigitePrimeiroNumero.Text = "Digite o primeiro número:";
            // 
            // lblDigiteSegundoNumero
            // 
            this.lblDigiteSegundoNumero.AutoSize = true;
            this.lblDigiteSegundoNumero.Location = new System.Drawing.Point(67, 101);
            this.lblDigiteSegundoNumero.Name = "lblDigiteSegundoNumero";
            this.lblDigiteSegundoNumero.Size = new System.Drawing.Size(128, 13);
            this.lblDigiteSegundoNumero.TabIndex = 1;
            this.lblDigiteSegundoNumero.Text = "Digite o segundo número:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(67, 159);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtDigitePrimeiroNumero
            // 
            this.txtDigitePrimeiroNumero.Location = new System.Drawing.Point(220, 49);
            this.txtDigitePrimeiroNumero.Name = "txtDigitePrimeiroNumero";
            this.txtDigitePrimeiroNumero.Size = new System.Drawing.Size(100, 20);
            this.txtDigitePrimeiroNumero.TabIndex = 3;
            // 
            // txtDigiteSegundoNumero
            // 
            this.txtDigiteSegundoNumero.Location = new System.Drawing.Point(211, 98);
            this.txtDigiteSegundoNumero.Name = "txtDigiteSegundoNumero";
            this.txtDigiteSegundoNumero.Size = new System.Drawing.Size(100, 20);
            this.txtDigiteSegundoNumero.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(161, 159);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(479, 49);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(45, 23);
            this.btnAdicao.TabIndex = 6;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(550, 49);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(45, 23);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(479, 95);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(45, 23);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(550, 95);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(45, 23);
            this.btnMultiplicacao.TabIndex = 9;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(531, 149);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(531, 187);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtDigiteSegundoNumero);
            this.Controls.Add(this.txtDigitePrimeiroNumero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDigiteSegundoNumero);
            this.Controls.Add(this.lblDigitePrimeiroNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblDigitePrimeiroNumero;
        private System.Windows.Forms.Label lblDigiteSegundoNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtDigitePrimeiroNumero;
        private System.Windows.Forms.TextBox txtDigiteSegundoNumero;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

