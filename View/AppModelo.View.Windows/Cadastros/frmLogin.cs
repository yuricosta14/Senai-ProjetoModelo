using AppModelo.Controller.Segurança;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
           

            var validacaoEmail = Validadores.EmailEValido(txtEmail.Text);
            
            if (validacaoEmail is false)
            {
                errorProvider1.SetError(txtEmail,
                    "E-mail incorreto");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if(usuarioEncontrado)
            {
                var form2 = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou sennha não encontrado");
            }


        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
