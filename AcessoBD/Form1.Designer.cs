
namespace AcessoBD
{
    partial class frmAcesso
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(73, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(31, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 31);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 31);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(148, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Estado :";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(31, 192);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(55, 31);
            this.txtUF.TabIndex = 5;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(27, 166);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(140, 23);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "Unidade Federal";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::AcessoBD.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(252, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::AcessoBD.Properties.Resources.search;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisa.Location = new System.Drawing.Point(252, 269);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(70, 70);
            this.btnPesquisa.TabIndex = 7;
            this.btnPesquisa.Text = "&Busca";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::AcessoBD.Properties.Resources.atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(21, 269);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(70, 70);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "A&tt";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::AcessoBD.Properties.Resources.adicionar;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(97, 269);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 70);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::AcessoBD.Properties.Resources.erase;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApagar.Location = new System.Drawing.Point(176, 269);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(70, 70);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "&Apaga";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // frmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAcesso";
            this.Text = "frmAcesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnApagar;
    }
}

