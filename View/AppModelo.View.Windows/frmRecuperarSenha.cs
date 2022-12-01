﻿using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Ao clicar no botão recuperar senha o email e validado para ver se e um email verdadeiro para assim ele enviar uma mensagem de recuperação de senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtEmail.Text);
            MessageBox.Show(resultado);
        }
    }
}
