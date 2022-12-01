using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        
        /// <summary>
        /// Com o metodo ObterTodasNacionalidades ao abrir o formúlario todas as nacionalidades cadastradas aparecera no datagridview
        /// </summary>
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        /// <summary>
        /// o clicar no botão salvar ele verifica se tem número no texto se tiver ele vai dar um erro e não irá salvar, 
        /// se não tiver ele salvara no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Ao clicar no botão de atualizar ele atualiza todas nacionalidades cadastradas no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var atualizar = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = atualizar;


        }

        /// <summary>
        /// Ao clicar no botão de excluir ele permitira apagar uma nacionalidade ja cadastrada no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var deletar = _nacionalidadeController.Deletar(txtDescricao.Text);
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
        
        /// <summary>
        /// Ao clicar no botão de editar ele permitira editar uma naturalidade ja cadastrada no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var editar = _nacionalidadeController.Atualizarr(id, txtDescricao.Text);
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;


        }

        
    }
}

