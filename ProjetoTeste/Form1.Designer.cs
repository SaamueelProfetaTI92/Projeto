namespace ProjetoTeste
{
    partial class frmEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolha));
            this.btnEscolhe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscolhe
            // 
            this.btnEscolhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolhe.Location = new System.Drawing.Point(14, 332);
            this.btnEscolhe.Name = "btnEscolhe";
            this.btnEscolhe.Size = new System.Drawing.Size(160, 55);
            this.btnEscolhe.TabIndex = 0;
            this.btnEscolhe.Text = "Escolher";
            this.btnEscolhe.UseVisualStyleBackColor = true;
            this.btnEscolhe.Click += new System.EventHandler(this.btnEscolhe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha números de 1 a 5";
            // 
            // txtEscolha
            // 
            this.txtEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscolha.Location = new System.Drawing.Point(26, 77);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(100, 29);
            this.txtEscolha.TabIndex = 2;
            this.txtEscolha.TextChanged += new System.EventHandler(this.txtEscolha_TextChanged);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnMensagem.Location = new System.Drawing.Point(202, 332);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(175, 55);
            this.btnMensagem.TabIndex = 3;
            this.btnMensagem.Text = "Exibir Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 409);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscolhe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEscolha;
        private System.Windows.Forms.Button btnMensagem;
    }
}

