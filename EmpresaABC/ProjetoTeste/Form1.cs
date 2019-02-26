using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void btnEscolhe_Click(object sender, EventArgs e)
        {
            String valor = "";
            int num = 0;

            if (txtEscolha.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um numero");
                txtEscolha.Clear();
                txtEscolha.Focus();                
            }
          
            switch (Convert.ToInt32(txtEscolha.Text))
            {
                case 1:
                    valor = "1";
                    num = 1;
                    break;
                case 2:
                    valor = "2";
                    num = 2;
                    break;
                case 3:
                    valor = "3";
                    num = 3;
                    break;
                case 4:
                    valor = "4";
                    num = 4;
                    break;
                case 5:
                    valor = "5";
                    num = 5;
                    break;
       
                default:
                    MessageBox.Show("Escolha um item  de 1 a 5");
                    break;        
            }
                if ((num > 0) && (num <= 5))
                {
                MessageBox.Show("Escolheu o item " + valor);
                txtEscolha.Focus();
                txtEscolha.Clear();
                //txtEscolha.Text = "";
                }

            
             
            
              
            

        private void button1_Click(object sender, EventArgs e)
        {
            double resp = 0, v1 = 50, v2 = 35;

            resp = v1 + v2;

            DialogResult mensagem = MessageBox.Show("A soma de " + v1 + "+" + v2 + " = " + resp,
                "Escolha Valor",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button3);

            if (mensagem == DialogResult.Yes)
            {
                MessageBox.Show("Você clicou no sim");
            }
            if (mensagem == DialogResult.No)
            {
                MessageBox.Show("Você clicou no não");
            }
            if (mensagem == DialogResult.Cancel)
            {
                MessageBox.Show("Você clicou no cancel");
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {


            string nome = "senac";
            if (txtbox.Text.Equals(nome))
            {
                MessageBox.Show("Olá, Seja bem vindo!!!!");
                
     
                txtbox.Focus();

            }
            else
            {
                MessageBox.Show("Favor insetir o nome!");
                txtbox.Focus();
                txtbox.Clear();
                

            }

             

        }
    }
}
