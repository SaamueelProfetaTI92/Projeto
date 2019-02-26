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
    public partial class FrmEstados : Form
    {
        public FrmEstados()
        {
            InitializeComponent();
            carregaCombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
           // carregaCombo();

        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExibir.Text = cboEstados.SelectedItem.ToString();
            ltbListaEstado.SelectedIndex = cboEstados.SelectedIndex;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboEstados.Items.Clear();
            ltbListaEstado.Items.Clear();
        }

        private void cboEstados_MouseClick(object sender, MouseEventArgs e)
        {

            //carregaCombo();
        }

        private void FrmEstados_Load(object sender, EventArgs e)
        {
            //carregaCombo();
        }
        public void carregaCombo()
        {
            cboEstados.Items.Clear();

            cboEstados.Items.Add("São Paulo");
            cboEstados.Items.Add("Bahia");
            cboEstados.Items.Add("Rio De Janeiro");
            cboEstados.Items.Add("Acre");
            cboEstados.Items.Add("Pernambuco");
            cboEstados.Items.Add("Sergipe");
            cboEstados.Items.Add("Manaus");
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
           carregalista();
        }

        public void carregalista()
        {
        
        ltbListaEstado.Items.Clear();

            ltbListaEstado.Items.Add("São Paulo");
            ltbListaEstado.Items.Add("Bahia");
            ltbListaEstado.Items.Add("Rio De Janeiro");
            ltbListaEstado.Items.Add("Acre");
            ltbListaEstado.Items.Add("Pernambuco");
            ltbListaEstado.Items.Add("Sergipe");
            ltbListaEstado.Items.Add("Manaus");
            ltbListaEstado.Items.Add("Parana");
            ltbListaEstado.Items.Add("Minas Gerais");
            ltbListaEstado.Items.Add("Fortaleza");
            ltbListaEstado.Items.Add("Santa Catarina");
        
        }

        private void btnCarregarLabel_Click(object sender, EventArgs e)
        {

            //lblExibir.Text = cboEstados.Text.ToString();
            lblExibir.Text = cboEstados.SelectedItem.ToString();

        }

        private void lblExibir_Click(object sender, EventArgs e)
        {

        }

        private void ltbListaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExibir2.Text = ltbListaEstado.SelectedItem.ToString();
            //ltbListaEstado.SelectedIndex = cboEstados.SelectedIndex;
            cboEstados.SelectedIndex = ltbListaEstado.SelectedIndex;

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblretorno.Text = "Masculino";
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            lblretorno.Text = "Feminino";

        }

        private void gpbEscolha_Enter(object sender, EventArgs e)
        {

        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("Você Escolheu Masculino");
            }
            if (rdbFeminino.Checked)
            {
                MessageBox.Show("Você Escolheu Feminino");
            }
        }
    }

}
