namespace GPSFrancisco
{
    partial class frmGerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuarios));
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbInformacoesUsuarios = new System.Windows.Forms.GroupBox();
            this.btCheckedFalse = new System.Windows.Forms.Button();
            this.btChecked = new System.Windows.Forms.Button();
            this.txtValidasenha = new System.Windows.Forms.TextBox();
            this.lblValidaSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lbUsuCadastrados = new System.Windows.Forms.Label();
            this.cbUsuCadastrados = new System.Windows.Forms.ComboBox();
            this.pnlCRUD.SuspendLayout();
            this.gpbInformacoesUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 416);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(876, 59);
            this.pnlCRUD.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(744, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(121, 42);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(621, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 42);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(497, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 42);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(374, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 42);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(252, 11);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 42);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(129, 11);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 42);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(4, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 42);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gpbInformacoesUsuarios
            // 
            this.gpbInformacoesUsuarios.Controls.Add(this.cbUsuCadastrados);
            this.gpbInformacoesUsuarios.Controls.Add(this.lbUsuCadastrados);
            this.gpbInformacoesUsuarios.Controls.Add(this.btCheckedFalse);
            this.gpbInformacoesUsuarios.Controls.Add(this.btChecked);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtValidasenha);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblValidaSenha);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtSenha);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblSenha);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtUsuario);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblUsuario);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtCodigo);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblCodigo);
            this.gpbInformacoesUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesUsuarios.Location = new System.Drawing.Point(44, 37);
            this.gpbInformacoesUsuarios.Name = "gpbInformacoesUsuarios";
            this.gpbInformacoesUsuarios.Size = new System.Drawing.Size(817, 283);
            this.gpbInformacoesUsuarios.TabIndex = 6;
            this.gpbInformacoesUsuarios.TabStop = false;
            this.gpbInformacoesUsuarios.Text = "Informações do usuário";
            // 
            // btCheckedFalse
            // 
            this.btCheckedFalse.FlatAppearance.BorderSize = 0;
            this.btCheckedFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckedFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckedFalse.Image = ((System.Drawing.Image)(resources.GetObject("btCheckedFalse.Image")));
            this.btCheckedFalse.Location = new System.Drawing.Point(454, 225);
            this.btCheckedFalse.Name = "btCheckedFalse";
            this.btCheckedFalse.Size = new System.Drawing.Size(35, 24);
            this.btCheckedFalse.TabIndex = 14;
            this.btCheckedFalse.UseVisualStyleBackColor = true;
            this.btCheckedFalse.Visible = false;
            // 
            // btChecked
            // 
            this.btChecked.FlatAppearance.BorderSize = 0;
            this.btChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChecked.Image = ((System.Drawing.Image)(resources.GetObject("btChecked.Image")));
            this.btChecked.Location = new System.Drawing.Point(454, 225);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(35, 24);
            this.btChecked.TabIndex = 13;
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Visible = false;
            // 
            // txtValidasenha
            // 
            this.txtValidasenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtValidasenha.Location = new System.Drawing.Point(252, 225);
            this.txtValidasenha.MaxLength = 12;
            this.txtValidasenha.Name = "txtValidasenha";
            this.txtValidasenha.PasswordChar = 'l';
            this.txtValidasenha.Size = new System.Drawing.Size(197, 25);
            this.txtValidasenha.TabIndex = 4;
            this.txtValidasenha.Click += new System.EventHandler(this.txtValidaSenha_TextChanged);
            // 
            // lblValidaSenha
            // 
            this.lblValidaSenha.AutoSize = true;
            this.lblValidaSenha.Location = new System.Drawing.Point(252, 197);
            this.lblValidaSenha.Name = "lblValidaSenha";
            this.lblValidaSenha.Size = new System.Drawing.Size(106, 20);
            this.lblValidaSenha.TabIndex = 6;
            this.lblValidaSenha.Text = "Validar senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(20, 225);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(197, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 197);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(20, 149);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 121);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 73);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 45);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lbUsuCadastrados
            // 
            this.lbUsuCadastrados.AutoSize = true;
            this.lbUsuCadastrados.Location = new System.Drawing.Point(556, 45);
            this.lbUsuCadastrados.Name = "lbUsuCadastrados";
            this.lbUsuCadastrados.Size = new System.Drawing.Size(167, 20);
            this.lbUsuCadastrados.TabIndex = 16;
            this.lbUsuCadastrados.Text = "Usuários Cadastrados";
            // 
            // cbUsuCadastrados
            // 
            this.cbUsuCadastrados.FormattingEnabled = true;
            this.cbUsuCadastrados.Location = new System.Drawing.Point(559, 81);
            this.cbUsuCadastrados.Name = "cbUsuCadastrados";
            this.cbUsuCadastrados.Size = new System.Drawing.Size(210, 28);
            this.cbUsuCadastrados.TabIndex = 17;
            this.cbUsuCadastrados.SelectedIndexChanged += new System.EventHandler(this.cbUsuCadastrados_SelectedIndexChanged);
            // 
            // frmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 487);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbInformacoesUsuarios);
            this.Name = "frmGerenciarUsuarios";
            this.Text = "frmGerenciausu";
            this.pnlCRUD.ResumeLayout(false);
            this.gpbInformacoesUsuarios.ResumeLayout(false);
            this.gpbInformacoesUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbInformacoesUsuarios;
        private System.Windows.Forms.Button btCheckedFalse;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.TextBox txtValidasenha;
        private System.Windows.Forms.Label lblValidaSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbUsuCadastrados;
        private System.Windows.Forms.Label lbUsuCadastrados;
    }
}