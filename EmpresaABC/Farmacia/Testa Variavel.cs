using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmTesteVariavel : Form
    {
        bool bandeira = false;
        public frmTesteVariavel()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            lblMostrar.Text = "Senac Largo Treze";
            lblINCompleto.Text = "Nome Completo";

            lblmostrarNumero.Text = "1";


        }

        private void btnBandeira_Click(object sender, EventArgs e)
        {
            bandeira = true;
            lblBandeira.Text = bandeira.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            lblINCompleto.Text = "";

            bandeira = false;

            lblBandeira.Text = bandeira.ToString();

            lblmostrarNumero.Text = "0";



        }
    }
}
