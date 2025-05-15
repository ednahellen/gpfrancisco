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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarusuario));
            this.gpUsuario = new System.Windows.Forms.GroupBox();
            this.btRedchecked = new System.Windows.Forms.Button();
            this.btChecked = new System.Windows.Forms.Button();
            this.plCrud = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtValsenha = new System.Windows.Forms.TextBox();
            this.lbValSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lbUsu = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbCod = new System.Windows.Forms.Label();
            this.txtUsucadastrado = new System.Windows.Forms.TextBox();
            this.lbUsucadastrado = new System.Windows.Forms.Label();
            this.gpUsuario.SuspendLayout();
            this.plCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpUsuario
            // 
            this.gpUsuario.Controls.Add(this.lbUsucadastrado);
            this.gpUsuario.Controls.Add(this.txtUsucadastrado);
            this.gpUsuario.Controls.Add(this.btRedchecked);
            this.gpUsuario.Controls.Add(this.btChecked);
            this.gpUsuario.Controls.Add(this.plCrud);
            this.gpUsuario.Controls.Add(this.txtValsenha);
            this.gpUsuario.Controls.Add(this.lbValSenha);
            this.gpUsuario.Controls.Add(this.txtSenha);
            this.gpUsuario.Controls.Add(this.lbSenha);
            this.gpUsuario.Controls.Add(this.txtUsu);
            this.gpUsuario.Controls.Add(this.lbUsu);
            this.gpUsuario.Controls.Add(this.txtCod);
            this.gpUsuario.Controls.Add(this.lbCod);
            this.gpUsuario.Location = new System.Drawing.Point(0, 0);
            this.gpUsuario.Name = "gpUsuario";
            this.gpUsuario.Size = new System.Drawing.Size(944, 371);
            this.gpUsuario.TabIndex = 0;
            this.gpUsuario.TabStop = false;
            this.gpUsuario.Text = "Informações do Usuário";
            // 
            // btRedchecked
            // 
            this.btRedchecked.FlatAppearance.BorderSize = 0;
            this.btRedchecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRedchecked.Image = ((System.Drawing.Image)(resources.GetObject("btRedchecked.Image")));
            this.btRedchecked.Location = new System.Drawing.Point(732, 181);
            this.btRedchecked.Name = "btRedchecked";
            this.btRedchecked.Size = new System.Drawing.Size(53, 27);
            this.btRedchecked.TabIndex = 10;
            this.btRedchecked.UseVisualStyleBackColor = true;
            this.btRedchecked.Visible = false;
            // 
            // btChecked
            // 
            this.btChecked.FlatAppearance.BorderSize = 0;
            this.btChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChecked.Image = ((System.Drawing.Image)(resources.GetObject("btChecked.Image")));
            this.btChecked.Location = new System.Drawing.Point(657, 177);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(69, 37);
            this.btChecked.TabIndex = 9;
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Visible = false;
            // 
            // plCrud
            // 
            this.plCrud.Controls.Add(this.btVoltar);
            this.plCrud.Controls.Add(this.btLimpar);
            this.plCrud.Controls.Add(this.btPesquisar);
            this.plCrud.Controls.Add(this.btAlterar);
            this.plCrud.Controls.Add(this.btExcluir);
            this.plCrud.Controls.Add(this.btCadastrar);
            this.plCrud.Controls.Add(this.btNovo);
            this.plCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plCrud.Location = new System.Drawing.Point(6, 240);
            this.plCrud.Name = "plCrud";
            this.plCrud.Size = new System.Drawing.Size(932, 125);
            this.plCrud.TabIndex = 8;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btVoltar.Image")));
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(803, 30);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(126, 47);
            this.btVoltar.TabIndex = 15;
            this.btVoltar.Text = "&Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(677, 30);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(126, 47);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(528, 30);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(145, 47);
            this.btPesquisar.TabIndex = 13;
            this.btPesquisar.Text = "&Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(266, 30);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(126, 47);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "&Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(397, 30);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(126, 47);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(134, 30);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(133, 47);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "&Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(5, 30);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(126, 47);
            this.btNovo.TabIndex = 9;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtValsenha
            // 
            this.txtValsenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtValsenha.Location = new System.Drawing.Point(460, 183);
            this.txtValsenha.MaxLength = 12;
            this.txtValsenha.Name = "txtValsenha";
            this.txtValsenha.PasswordChar = 'l';
            this.txtValsenha.Size = new System.Drawing.Size(191, 25);
            this.txtValsenha.TabIndex = 8;
            this.txtValsenha.TextChanged += new System.EventHandler(this.txtValsenha_TextChanged);
            // 
            // lbValSenha
            // 
            this.lbValSenha.AutoSize = true;
            this.lbValSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValSenha.Location = new System.Drawing.Point(456, 151);
            this.lbValSenha.Name = "lbValSenha";
            this.lbValSenha.Size = new System.Drawing.Size(109, 20);
            this.lbValSenha.TabIndex = 7;
            this.lbValSenha.Text = "Validar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(199, 183);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(191, 25);
            this.txtSenha.TabIndex = 6;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(204, 151);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(56, 20);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha";
            // 
            // txtUsu
            // 
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(460, 82);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(191, 26);
            this.txtUsu.TabIndex = 4;
            // 
            // lbUsu
            // 
            this.lbUsu.AutoSize = true;
            this.lbUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsu.Location = new System.Drawing.Point(465, 50);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(64, 20);
            this.lbUsu.TabIndex = 3;
            this.lbUsu.Text = "Usuário";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(199, 82);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(110, 26);
            this.txtCod.TabIndex = 1;
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(204, 50);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(59, 20);
            this.lbCod.TabIndex = 0;
            this.lbCod.Text = "Código";
            // 
            // txtUsucadastrado
            // 
            this.txtUsucadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsucadastrado.Location = new System.Drawing.Point(705, 82);
            this.txtUsucadastrado.Name = "txtUsucadastrado";
            this.txtUsucadastrado.Size = new System.Drawing.Size(191, 26);
            this.txtUsucadastrado.TabIndex = 11;
            // 
            // lbUsucadastrado
            // 
            this.lbUsucadastrado.AutoSize = true;
            this.lbUsucadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsucadastrado.Location = new System.Drawing.Point(701, 50);
            this.lbUsucadastrado.Name = "lbUsucadastrado";
            this.lbUsucadastrado.Size = new System.Drawing.Size(151, 20);
            this.lbUsucadastrado.TabIndex = 12;
            this.lbUsucadastrado.Text = "Usuário Cadastrado";
            // 
            // frmGerenciarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 373);
            this.Controls.Add(this.gpUsuario);
            this.Name = "frmGerenciarusuario";
            this.Text = "frmGerenciarusuario";
            this.gpUsuario.ResumeLayout(false);
            this.gpUsuario.PerformLayout();
            this.plCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpUsuario;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label lbValSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lbUsu;
        private System.Windows.Forms.Panel plCrud;
        private System.Windows.Forms.TextBox txtValsenha;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.Button btRedchecked;
        private System.Windows.Forms.Label lbUsucadastrado;
        private System.Windows.Forms.TextBox txtUsucadastrado;
    }
}