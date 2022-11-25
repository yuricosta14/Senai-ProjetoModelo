using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;

                var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
                gvNacionalidades.DataSource = listaDeNacionalidades;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var atualizar = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = atualizar;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var deletar = _nacionalidadeController.Deletar(txtDescricao.Text);
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var editar = _nacionalidadeController.Atualizarr(id, txtDescricao.Text);
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;


        }

        
    }
}

