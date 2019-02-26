namespace Atividade_25022019
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnGerenciarFunc = new System.Windows.Forms.Button();
            this.btnGerenciarProd = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnGerenciarUsua = new System.Windows.Forms.Button();
            this.ptbMenuPrincipal = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerenciarFunc
            // 
            this.btnGerenciarFunc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGerenciarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGerenciarFunc.Location = new System.Drawing.Point(316, 114);
            this.btnGerenciarFunc.Name = "btnGerenciarFunc";
            this.btnGerenciarFunc.Size = new System.Drawing.Size(246, 48);
            this.btnGerenciarFunc.TabIndex = 0;
            this.btnGerenciarFunc.Text = "Gerenciar Funcionários";
            this.btnGerenciarFunc.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarProd
            // 
            this.btnGerenciarProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGerenciarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGerenciarProd.Location = new System.Drawing.Point(316, 193);
            this.btnGerenciarProd.Name = "btnGerenciarProd";
            this.btnGerenciarProd.Size = new System.Drawing.Size(246, 45);
            this.btnGerenciarProd.TabIndex = 1;
            this.btnGerenciarProd.Text = "Gerenciar Produtos";
            this.btnGerenciarProd.UseVisualStyleBackColor = false;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFornecedores.Location = new System.Drawing.Point(316, 266);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(246, 45);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Gerenciar Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = false;
            // 
            // btnGerenciarUsua
            // 
            this.btnGerenciarUsua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGerenciarUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGerenciarUsua.Location = new System.Drawing.Point(316, 337);
            this.btnGerenciarUsua.Name = "btnGerenciarUsua";
            this.btnGerenciarUsua.Size = new System.Drawing.Size(246, 45);
            this.btnGerenciarUsua.TabIndex = 3;
            this.btnGerenciarUsua.Text = "Gerenciar Usuários";
            this.btnGerenciarUsua.UseVisualStyleBackColor = false;
            // 
            // ptbMenuPrincipal
            // 
            this.ptbMenuPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("ptbMenuPrincipal.Image")));
            this.ptbMenuPrincipal.Location = new System.Drawing.Point(12, 12);
            this.ptbMenuPrincipal.Name = "ptbMenuPrincipal";
            this.ptbMenuPrincipal.Size = new System.Drawing.Size(298, 510);
            this.ptbMenuPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMenuPrincipal.TabIndex = 4;
            this.ptbMenuPrincipal.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(350, 440);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 54);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(588, 562);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.ptbMenuPrincipal);
            this.Controls.Add(this.btnGerenciarUsua);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnGerenciarProd);
            this.Controls.Add(this.btnGerenciarFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenuPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarFunc;
        private System.Windows.Forms.Button btnGerenciarProd;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnGerenciarUsua;
        private System.Windows.Forms.PictureBox ptbMenuPrincipal;
        private System.Windows.Forms.Button btnVoltar;
    }
}