using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{   
    /// <summary>
    ///Instância das classes controllers de nacionalidade, naturalidade e funcionário
    /// </summary>
    public partial class frmCadastroFuncionario : Form
    {   
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private FuncionarioController _funcionarioController = new FuncionarioController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "id";
            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNaturalidade.ValueMember = "id";

            
        }


        /// <summary>
        /// botão para pesquisar o cep digitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }
        
        /// <summary>
        /// Validação do nome e verifica se a pessoa digitou algum número no lugar das letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //primeira regra nome < que 6 letras
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome,"Digite seu nome completo");
                return;
            }

            //verifica se digitou algum numero

            //SomenteLetras();
            //VerificarSeExisteNumeroNoTexto();

            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();

           
        }
        /// <summary>
        /// Valida se o cpf que foi digitado esta correto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Ao clicar nesse botão ira efetuar o cadastro do funcionario no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                int numero = int.Parse(txtEnderecoNumero.Text);
                var idNacionalidade = cmbNacionalidade.SelectedValue;
                var idNaturalidade = cmbNaturalidade.SelectedValue;

                int Nacionalidade = Convert.ToInt32(idNacionalidade);
                int Naturalidade = Convert.ToInt32(idNaturalidade);

                var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, rbMasculino.Checked, txtCpf.Text,
                    txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text,
                    numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text,
                    Nacionalidade, Naturalidade);

                if (salvou)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário");
                }

                limparDados(this);

                btnListagem.Visible = true;

            }
        }
        
        /// <summary>
        /// seleciona a Nacionalidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterIndexNacionalidade = cmbNacionalidade.SelectedIndex;
            string Index = cmbNacionalidade.Text;
            //MessageBox.Show(Index);
        }
       
        /// <summary>
        /// seleciona a Naturalidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNaturalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterIndexNaturalidade = cmbNaturalidade.SelectedIndex;
            string Index = cmbNaturalidade.Text;
            //MessageBox.Show(Index);

        }

        /// <summary>
        /// Ao clicar em salvar todos os campos serão limpados
        /// </summary>
        /// <param name="ctrl"></param>
        public static void limparDados(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).MinDate = new DateTime(1900, 1, 1);
                    ((DateTimePicker)c).MaxDate = new DateTime(2100, 1, 1);
                    ((DateTimePicker)c).Value = DateTime.Now.Date < ((DateTimePicker)c).MinDate ? ((DateTimePicker)c).MinDate : DateTime.Now.Date > ((DateTimePicker)c).MaxDate ? ((DateTimePicker)c).MaxDate : DateTime.Now.Date;
                    if (((DateTimePicker)c).ShowCheckBox)
                        ((DateTimePicker)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0 < ((NumericUpDown)c).Minimum ? ((NumericUpDown)c).Minimum : 0 > ((NumericUpDown)c).Maximum ? ((NumericUpDown)c).Maximum : 0;// ((NumericUpDown)c).Minimum;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
                else if (c is Label)
                {
                    //((Label)c).Text = "";
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else if (c is TrackBar)
                    ((TrackBar)c).Value = ((TrackBar)c).Minimum;
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 0;

                    limparDados(c);
                }
            }
        }
        
        /// <summary>
        /// Ao clicar em salvar ira aparecer um botão que ao clicar abre um formulario com todos os funcionarios cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConferir_Click(object sender, EventArgs e)
        {
            var form = new frmListagemFuncionarios();
            form.Show();
        }
    }
}
    
   
    

