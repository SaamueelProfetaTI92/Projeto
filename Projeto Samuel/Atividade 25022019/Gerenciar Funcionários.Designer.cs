namespace Atividade_25022019
{
    partial class frmGerenciarFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarFunc));
            this.lblFuncionários = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDadosBasicos = new System.Windows.Forms.Label();
            this.pnlDadosBasicos = new System.Windows.Forms.Panel();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlEnderecosResi = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pnlDadosBasicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFuncionários
            // 
            this.lblFuncionários.AutoSize = true;
            this.lblFuncionários.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionários.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFuncionários.Location = new System.Drawing.Point(309, 19);
            this.lblFuncionários.Name = "lblFuncionários";
            this.lblFuncionários.Size = new System.Drawing.Size(198, 39);
            this.lblFuncionários.TabIndex = 0;
            this.lblFuncionários.Text = "Funcionários";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblDadosBasicos
            // 
            this.lblDadosBasicos.AutoSize = true;
            this.lblDadosBasicos.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosBasicos.ForeColor = System.Drawing.Color.White;
            this.lblDadosBasicos.Location = new System.Drawing.Point(15, 93);
            this.lblDadosBasicos.Name = "lblDadosBasicos";
            this.lblDadosBasicos.Size = new System.Drawing.Size(139, 22);
            this.lblDadosBasicos.TabIndex = 3;
            this.lblDadosBasicos.Text = "Dados Basicos";
            // 
            // pnlDadosBasicos
            // 
            this.pnlDadosBasicos.Controls.Add(this.maskedTextBox1);
            this.pnlDadosBasicos.Controls.Add(this.lblCPF);
            this.pnlDadosBasicos.Controls.Add(this.textBox1);
            this.pnlDadosBasicos.Controls.Add(this.lblNome);
            this.pnlDadosBasicos.Location = new System.Drawing.Point(12, 128);
            this.pnlDadosBasicos.Name = "pnlDadosBasicos";
            this.pnlDadosBasicos.Size = new System.Drawing.Size(795, 79);
            this.pnlDadosBasicos.TabIndex = 4;
            this.pnlDadosBasicos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDadosBasicos_Paint);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(3, 37);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(54, 24);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.Location = new System.Drawing.Point(12, 210);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(203, 22);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço Residencial";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblLogradouro.ForeColor = System.Drawing.Color.White;
            this.lblLogradouro.Location = new System.Drawing.Point(15, 252);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(123, 22);
            this.lblLogradouro.TabIndex = 6;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 22);
            this.textBox3.TabIndex = 7;
            // 
            // pnlEnderecosResi
            // 
            this.pnlEnderecosResi.Location = new System.Drawing.Point(114, 328);
            this.pnlEnderecosResi.Name = "pnlEnderecosResi";
            this.pnlEnderecosResi.Size = new System.Drawing.Size(520, 79);
            this.pnlEnderecosResi.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(85, 38);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(118, 22);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // frmGerenciarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(845, 641);
            this.Controls.Add(this.pnlEnderecosResi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.pnlDadosBasicos);
            this.Controls.Add(this.lblDadosBasicos);
            this.Controls.Add(this.lblFuncionários);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarFunc";
            this.Text = "Gerenciar Funcionários";
            this.pnlDadosBasicos.ResumeLayout(false);
            this.pnlDadosBasicos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionários;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDadosBasicos;
        private System.Windows.Forms.Panel pnlDadosBasicos;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel pnlEnderecosResi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}