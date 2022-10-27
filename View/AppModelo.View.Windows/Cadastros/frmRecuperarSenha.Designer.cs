namespace AppModelo.View.Windows.Cadastros
{
    partial class frmRecuperarSenha
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
            this.components = new System.ComponentModel.Container();
            this.lblRecuperarSenha = new System.Windows.Forms.Label();
            this.txtRecuperacaoSenha = new System.Windows.Forms.TextBox();
            this.btnRecuperarAcesso = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecuperarSenha
            // 
            this.lblRecuperarSenha.AutoSize = true;
            this.lblRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarSenha.Location = new System.Drawing.Point(143, 40);
            this.lblRecuperarSenha.Name = "lblRecuperarSenha";
            this.lblRecuperarSenha.Size = new System.Drawing.Size(156, 24);
            this.lblRecuperarSenha.TabIndex = 0;
            this.lblRecuperarSenha.Text = "Recuperar senha";
            // 
            // txtRecuperacaoSenha
            // 
            this.txtRecuperacaoSenha.Location = new System.Drawing.Point(91, 120);
            this.txtRecuperacaoSenha.Name = "txtRecuperacaoSenha";
            this.txtRecuperacaoSenha.Size = new System.Drawing.Size(269, 20);
            this.txtRecuperacaoSenha.TabIndex = 3;
            // 
            // btnRecuperarAcesso
            // 
            this.btnRecuperarAcesso.Location = new System.Drawing.Point(91, 172);
            this.btnRecuperarAcesso.Name = "btnRecuperarAcesso";
            this.btnRecuperarAcesso.Size = new System.Drawing.Size(269, 27);
            this.btnRecuperarAcesso.TabIndex = 4;
            this.btnRecuperarAcesso.Text = "RECUPERAR ACESSO";
            this.btnRecuperarAcesso.UseVisualStyleBackColor = true;
            this.btnRecuperarAcesso.Click += new System.EventHandler(this.btnRecuperarAcesso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(91, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(269, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 319);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRecuperarAcesso);
            this.Controls.Add(this.txtRecuperacaoSenha);
            this.Controls.Add(this.lblRecuperarSenha);
            this.Name = "frmRecuperarSenha";
            this.Text = "frmRecuperarSenha";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperarSenha;
        private System.Windows.Forms.TextBox txtRecuperacaoSenha;
        private System.Windows.Forms.Button btnRecuperarAcesso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}