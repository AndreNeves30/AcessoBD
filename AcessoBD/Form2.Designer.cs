﻿
namespace AcessoBD
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblResul = new System.Windows.Forms.Label();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblResul2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::AcessoBD.Properties.Resources.erase;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagar.Location = new System.Drawing.Point(246, 365);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(70, 70);
            this.btnApagar.TabIndex = 21;
            this.btnApagar.Text = "&Apaga";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::AcessoBD.Properties.Resources.adicionar;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(167, 365);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 70);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::AcessoBD.Properties.Resources.atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(91, 365);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(70, 70);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "A&tt";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::AcessoBD.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(246, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 70);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(21, 163);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(25, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código :";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(25, 198);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 22;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(91, 198);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 23;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResul.Location = new System.Drawing.Point(224, 198);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(116, 29);
            this.lblResul.TabIndex = 24;
            this.lblResul.Text = "SUCESSO";
            this.lblResul.Visible = false;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = global::AcessoBD.Properties.Resources.primeiro;
            this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimeiro.Location = new System.Drawing.Point(20, 277);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(90, 70);
            this.btnPrimeiro.TabIndex = 25;
            this.btnPrimeiro.Text = "&Primeiro";
            this.btnPrimeiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::AcessoBD.Properties.Resources.ultimo;
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUltimo.Location = new System.Drawing.Point(308, 277);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(90, 70);
            this.btnUltimo.TabIndex = 26;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::AcessoBD.Properties.Resources.anterior;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnterior.Location = new System.Drawing.Point(116, 277);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(90, 70);
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::AcessoBD.Properties.Resources.proximo;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProximo.Location = new System.Drawing.Point(212, 277);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(90, 70);
            this.btnProximo.TabIndex = 28;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "André De Sousa Neves e Gabrielle Carvalho G Neves";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblResul2
            // 
            this.lblResul2.AutoSize = true;
            this.lblResul2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResul2.Location = new System.Drawing.Point(241, 198);
            this.lblResul2.Name = "lblResul2";
            this.lblResul2.Size = new System.Drawing.Size(86, 29);
            this.lblResul2.TabIndex = 30;
            this.lblResul2.Text = "FALHA";
            this.lblResul2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 484);
            this.Controls.Add(this.lblResul2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.rdbF);
            this.Controls.Add(this.rdbM);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblResul2;
    }
}