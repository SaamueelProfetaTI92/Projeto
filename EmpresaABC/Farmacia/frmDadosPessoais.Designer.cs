namespace Farmacia
{
    partial class frmDadosPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadosPessoais));
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.ltbEscolha = new System.Windows.Forms.ListBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbCrianca = new System.Windows.Forms.CheckBox();
            this.ckbJovem = new System.Windows.Forms.CheckBox();
            this.ckbAdulto = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPessoais.Location = new System.Drawing.Point(224, 28);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(230, 36);
            this.lblDadosPessoais.TabIndex = 0;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            this.lblDadosPessoais.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(189, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(190, 131);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 24);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            this.lblCargo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(166, 161);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(90, 24);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(123, 197);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(133, 24);
            this.lblDepartamento.TabIndex = 4;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(262, 89);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 27);
            this.txtNome.TabIndex = 5;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(262, 131);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(192, 27);
            this.txtCargo.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(262, 164);
            this.txtTelefone.MaxLength = 10;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 27);
            this.txtTelefone.TabIndex = 7;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Recursos Humanos",
            "Secretaria",
            "Administração Central",
            "Almoxarifado"});
            this.cboDepartamento.Location = new System.Drawing.Point(262, 197);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(192, 28);
            this.cboDepartamento.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(123, 442);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(173, 54);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(395, 442);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(168, 54);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSexo.Location = new System.Drawing.Point(192, 231);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 24);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rdbFeminino.Location = new System.Drawing.Point(262, 231);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(111, 28);
            this.rdbFeminino.TabIndex = 12;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rdbMasculino.Location = new System.Drawing.Point(379, 231);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(117, 28);
            this.rdbMasculino.TabIndex = 13;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ltbEscolha
            // 
            this.ltbEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ltbEscolha.FormattingEnabled = true;
            this.ltbEscolha.ItemHeight = 22;
            this.ltbEscolha.Items.AddRange(new object[] {
            "Calça",
            "Camisa",
            "Gravata",
            "Saia",
            "Chinelo"});
            this.ltbEscolha.Location = new System.Drawing.Point(404, 286);
            this.ltbEscolha.Name = "ltbEscolha";
            this.ltbEscolha.Size = new System.Drawing.Size(142, 92);
            this.ltbEscolha.TabIndex = 14;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblEscolha.Location = new System.Drawing.Point(315, 284);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(83, 24);
            this.lblEscolha.TabIndex = 15;
            this.lblEscolha.Text = "Escolha:";
            // 
            // ckbCrianca
            // 
            this.ckbCrianca.AutoSize = true;
            this.ckbCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ckbCrianca.Location = new System.Drawing.Point(208, 284);
            this.ckbCrianca.Name = "ckbCrianca";
            this.ckbCrianca.Size = new System.Drawing.Size(96, 28);
            this.ckbCrianca.TabIndex = 16;
            this.ckbCrianca.Text = "Criança";
            this.ckbCrianca.UseVisualStyleBackColor = true;
            // 
            // ckbJovem
            // 
            this.ckbJovem.AutoSize = true;
            this.ckbJovem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ckbJovem.Location = new System.Drawing.Point(208, 316);
            this.ckbJovem.Name = "ckbJovem";
            this.ckbJovem.Size = new System.Drawing.Size(88, 28);
            this.ckbJovem.TabIndex = 17;
            this.ckbJovem.Text = "Jovem";
            this.ckbJovem.UseVisualStyleBackColor = true;
            // 
            // ckbAdulto
            // 
            this.ckbAdulto.AutoSize = true;
            this.ckbAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ckbAdulto.Location = new System.Drawing.Point(208, 350);
            this.ckbAdulto.Name = "ckbAdulto";
            this.ckbAdulto.Size = new System.Drawing.Size(86, 28);
            this.ckbAdulto.TabIndex = 18;
            this.ckbAdulto.Text = "Adulto";
            this.ckbAdulto.UseVisualStyleBackColor = true;
            this.ckbAdulto.CheckedChanged += new System.EventHandler(this.ckbAdulto_CheckedChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTipo.Location = new System.Drawing.Point(149, 284);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 24);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Tipo:";
            // 
            // frmDadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 548);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.ckbAdulto);
            this.Controls.Add(this.ckbJovem);
            this.Controls.Add(this.ckbCrianca);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.ltbEscolha);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblDadosPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDadosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmácia - Dados Pessoais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.ListBox ltbEscolha;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.CheckBox ckbCrianca;
        private System.Windows.Forms.CheckBox ckbJovem;
        private System.Windows.Forms.CheckBox ckbAdulto;
        private System.Windows.Forms.Label lblTipo;
    }
}