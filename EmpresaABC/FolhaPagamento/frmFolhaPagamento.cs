using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
            carregaclube();
        }

        private void cboClube_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaclube();
        }

        public void carregaclube()
        { 
            cboClube.Items.Add("Clube A - R$ 100,00");
            cboClube.Items.Add("Clube B - R$ 50,00");
            cboClube.Items.Add("Clube C - R$ 10,00");
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numsal1, resp1 = 0;

            numsal1 = Double.Parse(txtSalario.Text);

            txtSalarioFolha.Text = txtSalario.Text;

            if (ckbPlanoSaude.Checked)
            {
                resp1 = numsal1 - 150;
                txtSalarioFolha.Text = resp1.ToString();
            }
                  
                               
        }

        private void ckbPlanoSaude_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
