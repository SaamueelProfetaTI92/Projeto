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
            this.btnTeste = new System.Windows.Forms.Button();
            this.lblTeste = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEscolhe
            // 
            this.btnEscolhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolhe.Location = new System.Drawing.Point(19, 409);
            this.btnEscolhe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEscolhe.Name = "btnEscolhe";
            this.btnEscolhe.Size = new System.Drawing.Size(213, 68);
            this.btnEscolhe.TabIndex = 0;
            this.btnEscolhe.Text = "Escolher";
            this.btnEscolhe.UseVisualStyleBackColor = true;
            this.btnEscolhe.Click += new System.EventHandler(this.btnEscolhe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha números de 1 a 5";
            // 
            // txtEscolha
            // 
            this.txtEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscolha.Location = new System.Drawing.Point(35, 95);
            this.txtEscolha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(132, 34);
            this.txtEscolha.TabIndex = 2;
            // 
            // btnMensagem
            // 
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnMensagem.Location = new System.Drawing.Point(269, 409);
            this.btnMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(233, 68);
            this.btnMensagem.TabIndex = 3;
            this.btnMensagem.Text = "Exibir Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeste.Location = new System.Drawing.Point(35, 245);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(103, 48);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste.Location = new System.Drawing.Point(37, 176);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(95, 25);
            this.lblTeste.TabIndex = 5;
            this.lblTeste.Text = "Testando";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(42, 217);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 22);
            this.txtbox.TabIndex = 6;
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 503);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscolhe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.TextBox txtbox;
    }
}

