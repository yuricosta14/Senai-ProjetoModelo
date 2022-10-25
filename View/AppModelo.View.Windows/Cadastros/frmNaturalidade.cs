using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidade;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var controller = new NaturalidadeController();
            var salvou = controller.Cadastrar(txtCadastrar.Text);
            if (salvou)
            {
                MessageBox.Show("Naturalidade incluida com sucesso");
                txtCadastrar.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao incluir sua naturalidade");
            }
        }

        private void txtCadastrar_TextChanged(object sender, EventArgs e)
        {
            //if(txtCadastrar.Text )   
            {

            }
        }
    }
}
