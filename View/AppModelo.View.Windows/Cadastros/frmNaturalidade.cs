using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadecontroller = new NaturalidadeController();
    
      
    
        public frmNaturalidade()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Ao clicar no botão salvar ele verifica se tem número no texto se tiver ele vai dar um erro e não irá salvar, 
        /// se não tiver ele salvara no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var temNumero = 
                Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
           
            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao, 
                    "Naturalidades geralmente não tem número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkStatus.Checked);

        }
        
        /// <summary>
        /// Com o metodo ObterTodasNaturalidades ao abrir o formúlario todas as naturalidades cadastradas aparecera no datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNaturalidade_Load(object sender, EventArgs e)
        {
            var controller = new NaturalidadeController();
            var dataSource = controller.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = dataSource;

        }
        
        /// <summary>
        /// Ao clicar no botão de editar ele permitira editar uma naturalidade ja cadastrada no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var editar = _naturalidadecontroller.Atualizarr(id, txtDescricao.Text);
            var listaDeNacionalidades = _naturalidadecontroller.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNacionalidades;
        }
        
        /// <summary>
        /// Ao clicar no botão de atualizar ele atualiza todas naturalidades cadastradas no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var atualizar = _naturalidadecontroller.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = atualizar;
        }

        /// <summary>
        /// Ao clicar no botão de excluir ele permitira apagar uma naturalidade ja cadastrada no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var deletar = _naturalidadecontroller.Deletar(txtDescricao.Text);
            var listaDeNacionalidades = _naturalidadecontroller.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNacionalidades;
        }

        
    }
}
