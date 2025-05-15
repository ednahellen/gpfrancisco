using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmGerenciarUsuarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            //executando o método desabilitar campos
            desabilitarCampos();
        }

        //desabilitar campos
        public void desabilitarCampos()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidasenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidasenha.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtUsuario.Focus();
        }

        //desabilitar campos cadastrar
        public void desabilitarCamposCadastrar()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidasenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidasenha.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executando o método limpar campos
            limparCampos();
        }
        //criando o método limpar campos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidasenha.Clear();
            txtUsuario.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("")
                || txtSenha.Text.Equals("")
                || txtValidasenha.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                limparCampos();
            }
            else
            {
                if (txtSenha.Text.Length < 12 || txtValidasenha.Text.Length < 12)
                {
                    MessageBox.Show("A senha tem que ser igual a 12 caracteres",
                       "Mensagem do sistema",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error,
                      MessageBoxDefaultButton.Button1
                      );
                }
                else
                {
                    if (txtSenha.Text.Equals(txtValidasenha.Text))
                    {
                        MessageBox.Show("Cadastrado com sucesso.",
                             "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1
                            );
                        desabilitarCamposCadastrar();
                    }
                    else
                    {
                        MessageBox.Show("A senha não é igual.",
                             "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                            );
                        txtSenha.Clear();
                        txtValidasenha.Clear();
                        txtSenha.Focus();
                    }
                }



            }
        }

        private void txtValidaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtValidasenha.Text.Equals(txtSenha.Text))
            {
                btChecked.Visible = true;
            }
            else
            {
                if (txtValidasenha.Text.Length == 12)
                {
                    btCheckedFalse.Visible = true;
                }
            }
        }
        //Criando o método para desabilitar os campos
        public int cadastrarUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuario(nome,senha)values(@nome,@senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }
        public void buscarUsuariosCadastrados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbusuario order by nome asc";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            Conexao.fecharConexao();

        }
        public int cadastrarUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuario(nome,senha)values(@nome,@senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        //buscar usuarios cadastrados
        public void buscarUsuariosCadastrados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbusuarios order by nome asc";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbUsuCadastrados.Items.Add(DR.GetString(0));
            }
            DR.Read();

            Conexao.fecharConexao();

        }
        //public void alterar usuario
        public void alterarUsuario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nome = @nome, senha = @senha where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add().value = txtUsuario.Text;

            comm.Connection = Conexao.obterConexao();
            Conexao.fecharConexao();

        }

        private void cbUsuCadastrados_Click(object sender, EventArgs e)
        {
            buscarUsuariosCadastrados();
        }

        public void buscarUsuariocodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = 1;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetString(0);

            Conexao.fecharConexao();
        }
    }
}




