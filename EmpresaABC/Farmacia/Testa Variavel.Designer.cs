namespace Farmacia
{
    partial class frmTesteVariavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteVariavel));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblINCompleto = new System.Windows.Forms.Label();
            this.btnBandeira = new System.Windows.Forms.Button();
            this.lblBandeira = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblmostrarNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(37, 51);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(123, 77);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(37, 199);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 77);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Location = new System.Drawing.Point(300, 51);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(289, 77);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblINCompleto
            // 
            this.lblINCompleto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblINCompleto.Location = new System.Drawing.Point(300, 199);
            this.lblINCompleto.Name = "lblINCompleto";
            this.lblINCompleto.Size = new System.Drawing.Size(289, 77);
            this.lblINCompleto.TabIndex = 3;
            this.lblINCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(37, 359);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(183, 77);
            this.btnBandeira.TabIndex = 4;
            this.btnBandeira.Text = "Bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            this.btnBandeira.Click += new System.EventHandler(this.btnBandeira_Click);
            // 
            // lblBandeira
            // 
            this.lblBandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandeira.Location = new System.Drawing.Point(284, 359);
            this.lblBandeira.Name = "lblBandeira";
            this.lblBandeira.Size = new System.Drawing.Size(262, 77);
            this.lblBandeira.TabIndex = 5;
            this.lblBandeira.Text = "false";
            this.lblBandeira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(620, 359);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(186, 77);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpa";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblmostrarNumero
            // 
            this.lblmostrarNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmostrarNumero.Location = new System.Drawing.Point(647, 199);
            this.lblmostrarNumero.Name = "lblmostrarNumero";
            this.lblmostrarNumero.Size = new System.Drawing.Size(122, 77);
            this.lblmostrarNumero.TabIndex = 7;
            this.lblmostrarNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTesteVariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 479);
            this.Controls.Add(this.lblmostrarNumero);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblBandeira);
            this.Controls.Add(this.btnBandeira);
            this.Controls.Add(this.lblINCompleto);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteVariavel";
            this.Text = "Teste de Variavel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblINCompleto;
        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.Label lblBandeira;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblmostrarNumero;
    }
}