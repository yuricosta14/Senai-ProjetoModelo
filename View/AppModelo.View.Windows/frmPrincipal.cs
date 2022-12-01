using AppModelo.View.Windows.Cadastros;
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

        /// <summary>
        /// Ao clicar em cadastros e selcionar nacionalidades ele abre o formulario para poder cadastrar as nacionalidades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// Ao clicar em cadastros e selcionar naturalidades ele abre o formulario para poder cadastrar as naturalidades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naturalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();

        }
        
        /// <summary>
        /// Ao clicar em cadastros e selcionar funcionarios ele abre o formulario para poder cadastrar novos funcionarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
