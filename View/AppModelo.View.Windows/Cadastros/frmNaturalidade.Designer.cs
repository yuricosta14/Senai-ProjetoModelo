namespace AppModelo.View.Windows.Cadastros
{
    partial class frmNaturalidade
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
            this.lblDiga = new System.Windows.Forms.Label();
            this.txtCadastrar = new System.Windows.Forms.TextBox();
            this.gvNaturalidade = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiga
            // 
            this.lblDiga.AutoSize = true;
            this.lblDiga.Location = new System.Drawing.Point(124, 66);
            this.lblDiga.Name = "lblDiga";
            this.lblDiga.Size = new System.Drawing.Size(388, 13);
            this.lblDiga.TabIndex = 0;
            this.lblDiga.Text = "SE SUA NATURALIDADE AINDA NÃO FOI CADASTRADA NOS DIGA QUAL É";
            // 
            // txtCadastrar
            // 
            this.txtCadastrar.Location = new System.Drawing.Point(184, 91);
            this.txtCadastrar.Name = "txtCadastrar";
            this.txtCadastrar.Size = new System.Drawing.Size(251, 20);
            this.txtCadastrar.TabIndex = 1;
            // 
            // gvNaturalidade
            // 
            this.gvNaturalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNaturalidade.Location = new System.Drawing.Point(32, 173);
            this.gvNaturalidade.Name = "gvNaturalidade";
            this.gvNaturalidade.Size = new System.Drawing.Size(573, 215);
            this.gvNaturalidade.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(274, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmNaturalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 421);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gvNaturalidade);
            this.Controls.Add(this.txtCadastrar);
            this.Controls.Add(this.lblDiga);
            this.Name = "frmNaturalidade";
            this.Text = "frmNaturalidade";
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiga;
        private System.Windows.Forms.TextBox txtCadastrar;
        private System.Windows.Forms.DataGridView gvNaturalidade;
        private System.Windows.Forms.Button btnSalvar;
    }
}