namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblDataDaFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.cboClube = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblimposto = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtSalarioRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(30, 94);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(138, 28);
            this.dtpDataFolha.TabIndex = 0;
            // 
            // lblDataDaFolha
            // 
            this.lblDataDaFolha.AutoSize = true;
            this.lblDataDaFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDaFolha.Location = new System.Drawing.Point(27, 54);
            this.lblDataDaFolha.Name = "lblDataDaFolha";
            this.lblDataDaFolha.Size = new System.Drawing.Size(126, 24);
            this.lblDataDaFolha.TabIndex = 1;
            this.lblDataDaFolha.Text = "Data da Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSalario.Location = new System.Drawing.Point(27, 144);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(72, 24);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário:";
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ckbPlanoSaude.Location = new System.Drawing.Point(31, 225);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(140, 28);
            this.ckbPlanoSaude.TabIndex = 3;
            this.ckbPlanoSaude.Text = "Plano Saude";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            this.ckbPlanoSaude.CheckedChanged += new System.EventHandler(this.ckbPlanoSaude_CheckedChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(31, 180);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(114, 22);
            this.txtSalario.TabIndex = 4;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblClubeLazer.Location = new System.Drawing.Point(30, 280);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(138, 24);
            this.lblClubeLazer.TabIndex = 5;
            this.lblClubeLazer.Text = "Clube de Lazer";
            // 
            // cboClube
            // 
            this.cboClube.FormattingEnabled = true;
            this.cboClube.Location = new System.Drawing.Point(34, 322);
            this.cboClube.Name = "cboClube";
            this.cboClube.Size = new System.Drawing.Size(164, 24);
            this.cboClube.TabIndex = 6;
            this.cboClube.SelectedIndexChanged += new System.EventHandler(this.cboClube_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCalcular.Location = new System.Drawing.Point(336, 54);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 44);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcula";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSalarioFolha.Location = new System.Drawing.Point(331, 144);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(120, 24);
            this.lblSalarioFolha.TabIndex = 8;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // lblimposto
            // 
            this.lblimposto.AutoSize = true;
            this.lblimposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblimposto.Location = new System.Drawing.Point(331, 191);
            this.lblimposto.Name = "lblimposto";
            this.lblimposto.Size = new System.Drawing.Size(164, 24);
            this.lblimposto.TabIndex = 9;
            this.lblimposto.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSalarioLiquido.Location = new System.Drawing.Point(332, 236);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(134, 24);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Location = new System.Drawing.Point(457, 144);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(101, 22);
            this.txtSalarioFolha.TabIndex = 11;
            // 
            // txtSalarioRenda
            // 
            this.txtSalarioRenda.Enabled = false;
            this.txtSalarioRenda.Location = new System.Drawing.Point(501, 191);
            this.txtSalarioRenda.Name = "txtSalarioRenda";
            this.txtSalarioRenda.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioRenda.TabIndex = 12;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(489, 238);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioLiquido.TabIndex = 13;
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 535);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioRenda);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblimposto);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboClube);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataDaFolha);
            this.Controls.Add(this.dtpDataFolha);
            this.Name = "frmFolhaPagamento";
            this.Text = "frmFolhaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblDataDaFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.ComboBox cboClube;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblimposto;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtSalarioRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
    }
}