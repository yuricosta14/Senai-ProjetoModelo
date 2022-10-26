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
            form.Show();
            this.Close();

            var validacaoEmail = Validadores.EmailEValido(txtEmail.Text);
            
            if (validacaoEmail)
            {
                errorProvider1.SetError(txtEmail,
                    "E-mail incorreto");
                txtEmail.Focus();
                return;

               
            }

        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }
    }
}
