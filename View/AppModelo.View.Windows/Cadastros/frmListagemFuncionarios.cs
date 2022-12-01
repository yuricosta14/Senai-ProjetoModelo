using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmListagemFuncionarios : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();

        /// <summary>
        /// Com o metodo ObterTodosFuncionarios ao abrir o formúlario todas os funcionarios cadastrados aparecera no datagridview
        /// </summary>
        public frmListagemFuncionarios()
        {
            InitializeComponent();

            var listaDeFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvListagemFuncionarios.DataSource = listaDeFuncionarios;
        }

        /// <summary>
        /// Ao clicar no botão de excluir ele permitira apagar um funcionario ja cadastrado no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var deletar = _funcionarioController.Deletar(txtDescricao.Text);
            var listaDeFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvListagemFuncionarios.DataSource = listaDeFuncionarios;
        }
    }
}
