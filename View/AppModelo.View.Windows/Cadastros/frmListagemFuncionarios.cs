using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmListagemFuncionarios : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();

        public frmListagemFuncionarios()
        {
            InitializeComponent();

            var listaDeFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvListagemFuncionarios.DataSource = listaDeFuncionarios;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var deletar = _funcionarioController.Deletar(txtDescricao.Text);
            var listaDeFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvListagemFuncionarios.DataSource = listaDeFuncionarios;
        }
    }
}
