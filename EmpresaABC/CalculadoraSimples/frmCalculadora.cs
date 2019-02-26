using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            num1 = Double.Parse(txtval1.Text);
            num2 = Double.Parse(txtval2.Text);


            if (rdbAdicao.Checked)
            {
                resp = num1 + num2;
                lblResposta2.Text = resp.ToString();
            }

            if (rdbSubtração.Checked)
            {
                resp = num1 - num2;
                lblResposta2.Text = resp.ToString();
            }

            if (rdbMultiplicacao.Checked)
            {
                resp = num1 * num2;
                lblResposta2.Text = resp.ToString();
            }

            if (rdbDivisao.Checked)
            {
                resp = num1 / num2;
                lblResposta2.Text = resp.ToString();
            }

            if (rdbDivisao.Checked)
            {
                resp = num1 / 0;
                lblResposta2.Text = resp.ToString();
            }

            if (rdbDivisao.Checked)
            {
                resp = num1 = 0;
                lblResposta2.Text = "Impossivel";
            }       

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtval1.Text = "";
            txtval2.Text = "";
            lblResposta2.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtval1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbAdicao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
