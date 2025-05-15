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
            txtUsu.Enabled = false;
            txtSenha.Enabled = false;
            txtValsenha.Enabled = false;
            btCadastrar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btLimpar.Enabled = false;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtUsu.Enabled = true;
            txtSenha.Enabled = true;
            txtValsenha.Enabled = true;
            btCadastrar.Enabled = true;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btLimpar.Enabled = true;
            btNovo.Enabled = false;
            txtUsu.Focus();
        }

        //desabilitar campos cadastrar
        public void desabilitarCamposCadastrar()
        {
            txtUsu.Enabled = false;
            txtSenha.Enabled = false;
            txtValsenha.Enabled = false;
            btCadastrar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btLimpar.Enabled = false;
            btNovo.Enabled = true;
            txtUsu.Clear();
            txtSenha.Clear();
            txtValsenha.Clear();
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
            txtCod.Clear();
            txtUsu.Clear();
            txtSenha.Clear();
            txtValsenha.Clear();
            txtUsu.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text.Equals("")
                || txtSenha.Text.Equals("")
                || txtValsenha.Text.Equals(""))
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
                if (txtSenha.Text.Length < 12 || txtValsenha.Text.Length < 12)
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
                    if (txtSenha.Text.Equals(txtValsenha.Text))
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
                        txtValsenha.Clear();
                        txtSenha.Focus();
                    }
                }



            }
        }

        private void txtValidaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtValsenha.Text.Equals(txtSenha.Text))
            {
                btChecked.Visible = true;
            }
            else
            {
                if (txtValsenha.Text.Length == 12)
                {
                    btCheckedFalse.Visible = true;
                }
            }
        }
    }//Criando o método para desabilitar os campos
    public void cadastrarUsuario()
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
}


   
