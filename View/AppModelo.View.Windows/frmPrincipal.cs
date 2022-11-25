﻿using AppModelo.View.Windows.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void naturalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
