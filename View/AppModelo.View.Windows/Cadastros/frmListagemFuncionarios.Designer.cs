namespace AppModelo.View.Windows.Cadastros
{
    partial class frmListagemFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvListagemFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvListagemFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListagemFuncionarios
            // 
            this.gvListagemFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListagemFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.gvListagemFuncionarios.Name = "gvListagemFuncionarios";
            this.gvListagemFuncionarios.Size = new System.Drawing.Size(567, 343);
            this.gvListagemFuncionarios.TabIndex = 0;
            this.gvListagemFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListagemFuncionarios_CellContentClick);
            // 
            // frmListagemFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 341);
            this.Controls.Add(this.gvListagemFuncionarios);
            this.Name = "frmListagemFuncionarios";
            this.Text = "frmListagemFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.gvListagemFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListagemFuncionarios;
    }
}