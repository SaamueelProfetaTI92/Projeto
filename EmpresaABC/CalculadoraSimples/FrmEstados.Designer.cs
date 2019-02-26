namespace CalculadoraSimples
{
    partial class FrmEstados
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEstados = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.ltbListaEstado = new System.Windows.Forms.ListBox();
            this.btnCarregarLista = new System.Windows.Forms.Button();
            this.btnCarregarLabel = new System.Windows.Forms.Button();
            this.lblExibir = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.lbllista = new System.Windows.Forms.Label();
            this.lblExibir2 = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.lblretorno = new System.Windows.Forms.Label();
            this.ckbManha = new System.Windows.Forms.CheckBox();
            this.ckbTarde = new System.Windows.Forms.CheckBox();
            this.ckbNoite = new System.Windows.Forms.CheckBox();
            this.gpbEscolha = new System.Windows.Forms.GroupBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gpbEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCarregar.Location = new System.Drawing.Point(31, 262);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(179, 46);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar Estados";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(415, 262);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(161, 46);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(83, 53);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(83, 25);
            this.lblEstados.TabIndex = 2;
            this.lblEstados.Text = "Estados";
            this.lblEstados.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(88, 107);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 24);
            this.cboEstados.TabIndex = 3;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            this.cboEstados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboEstados_MouseClick);
            // 
            // ltbListaEstado
            // 
            this.ltbListaEstado.FormattingEnabled = true;
            this.ltbListaEstado.ItemHeight = 16;
            this.ltbListaEstado.Location = new System.Drawing.Point(315, 28);
            this.ltbListaEstado.Name = "ltbListaEstado";
            this.ltbListaEstado.Size = new System.Drawing.Size(132, 164);
            this.ltbListaEstado.TabIndex = 4;
            this.ltbListaEstado.SelectedIndexChanged += new System.EventHandler(this.ltbListaEstado_SelectedIndexChanged);
            // 
            // btnCarregarLista
            // 
            this.btnCarregarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCarregarLista.Location = new System.Drawing.Point(231, 262);
            this.btnCarregarLista.Name = "btnCarregarLista";
            this.btnCarregarLista.Size = new System.Drawing.Size(161, 46);
            this.btnCarregarLista.TabIndex = 5;
            this.btnCarregarLista.Text = "Carrega Lista";
            this.btnCarregarLista.UseVisualStyleBackColor = true;
            this.btnCarregarLista.Click += new System.EventHandler(this.btnCarregarLista_Click);
            // 
            // btnCarregarLabel
            // 
            this.btnCarregarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCarregarLabel.Location = new System.Drawing.Point(31, 357);
            this.btnCarregarLabel.Name = "btnCarregarLabel";
            this.btnCarregarLabel.Size = new System.Drawing.Size(179, 41);
            this.btnCarregarLabel.TabIndex = 6;
            this.btnCarregarLabel.Text = "Carregar Label";
            this.btnCarregarLabel.UseVisualStyleBackColor = true;
            this.btnCarregarLabel.Click += new System.EventHandler(this.btnCarregarLabel_Click);
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(250, 372);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(0, 17);
            this.lblExibir.TabIndex = 7;
            this.lblExibir.Click += new System.EventHandler(this.lblExibir_Click);
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Location = new System.Drawing.Point(250, 346);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(52, 17);
            this.lblitem.TabIndex = 8;
            this.lblitem.Text = "Combo";
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(385, 346);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(38, 17);
            this.lbllista.TabIndex = 9;
            this.lbllista.Text = "Lista";
            // 
            // lblExibir2
            // 
            this.lblExibir2.AutoSize = true;
            this.lblExibir2.Location = new System.Drawing.Point(392, 372);
            this.lblExibir2.Name = "lblExibir2";
            this.lblExibir2.Size = new System.Drawing.Size(0, 17);
            this.lblExibir2.TabIndex = 10;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(36, 38);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(122, 29);
            this.rdbMasculino.TabIndex = 11;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(36, 86);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(113, 29);
            this.rdbFeminino.TabIndex = 12;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbSexo.Location = new System.Drawing.Point(518, 28);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 145);
            this.gpbSexo.TabIndex = 13;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // lblretorno
            // 
            this.lblretorno.AutoSize = true;
            this.lblretorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblretorno.Location = new System.Drawing.Point(513, 196);
            this.lblretorno.Name = "lblretorno";
            this.lblretorno.Size = new System.Drawing.Size(223, 25);
            this.lblretorno.TabIndex = 14;
            this.lblretorno.Text = "Retorno do Radio Button";
            // 
            // ckbManha
            // 
            this.ckbManha.AutoSize = true;
            this.ckbManha.Location = new System.Drawing.Point(54, 29);
            this.ckbManha.Name = "ckbManha";
            this.ckbManha.Size = new System.Drawing.Size(95, 29);
            this.ckbManha.TabIndex = 15;
            this.ckbManha.Text = "Manhã";
            this.ckbManha.UseVisualStyleBackColor = true;
            // 
            // ckbTarde
            // 
            this.ckbTarde.AutoSize = true;
            this.ckbTarde.Location = new System.Drawing.Point(54, 64);
            this.ckbTarde.Name = "ckbTarde";
            this.ckbTarde.Size = new System.Drawing.Size(86, 29);
            this.ckbTarde.TabIndex = 16;
            this.ckbTarde.Text = "Tarde";
            this.ckbTarde.UseVisualStyleBackColor = true;
            // 
            // ckbNoite
            // 
            this.ckbNoite.AutoSize = true;
            this.ckbNoite.Location = new System.Drawing.Point(54, 99);
            this.ckbNoite.Name = "ckbNoite";
            this.ckbNoite.Size = new System.Drawing.Size(79, 29);
            this.ckbNoite.TabIndex = 17;
            this.ckbNoite.Text = "Noite";
            this.ckbNoite.UseVisualStyleBackColor = true;
            // 
            // gpbEscolha
            // 
            this.gpbEscolha.Controls.Add(this.ckbManha);
            this.gpbEscolha.Controls.Add(this.ckbNoite);
            this.gpbEscolha.Controls.Add(this.ckbTarde);
            this.gpbEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbEscolha.Location = new System.Drawing.Point(779, 28);
            this.gpbEscolha.Name = "gpbEscolha";
            this.gpbEscolha.Size = new System.Drawing.Size(200, 145);
            this.gpbEscolha.TabIndex = 18;
            this.gpbEscolha.TabStop = false;
            this.gpbEscolha.Text = "Escolha";
            this.gpbEscolha.Enter += new System.EventHandler(this.gpbEscolha_Enter);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEscolha.Location = new System.Drawing.Point(617, 262);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(144, 46);
            this.btnEscolha.TabIndex = 19;
            this.btnEscolha.Text = "Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 472);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.gpbEscolha);
            this.Controls.Add(this.lblretorno);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblExibir2);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnCarregarLabel);
            this.Controls.Add(this.btnCarregarLista);
            this.Controls.Add(this.ltbListaEstado);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregar);
            this.Name = "FrmEstados";
            this.Text = "FrmEstados";
            this.Load += new System.EventHandler(this.FrmEstados_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbEscolha.ResumeLayout(false);
            this.gpbEscolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ListBox ltbListaEstado;
        private System.Windows.Forms.Button btnCarregarLista;
        private System.Windows.Forms.Button btnCarregarLabel;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label lbllista;
        private System.Windows.Forms.Label lblExibir2;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.Label lblretorno;
        private System.Windows.Forms.CheckBox ckbManha;
        private System.Windows.Forms.CheckBox ckbTarde;
        private System.Windows.Forms.CheckBox ckbNoite;
        private System.Windows.Forms.GroupBox gpbEscolha;
        private System.Windows.Forms.Button btnEscolha;
    }
}