using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();

        public frmCadastroFuncionario()
        {
            InitializeComponent();

            Componentes.FormatarCamposObrigatorios(this);
            cbmNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cbmNacionalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //criou a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite o seu nome completo");

                return;
            }
            else
            {
                errorProvider.Clear();

            }
            

            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome deve conter somente letras");

                    return;
                }
                errorProvider.Clear();  



            }
        }

        public void  txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);

            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Invalido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailValido = Validadores.EmailEValido(email);

            if (emailValido is false)
            {
                errorProvider.SetError(txtEmail, "Seu email e invalido");
                return;
            }
            errorProvider.Clear();
        }
    }
}
