using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (acessaUsuario(usuario,senha))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        public void limparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }
        bool resp = false;

        //criando um método para acesso do usuário

        public bool acessaUsuario(string nome, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome,senha from tbUsuarios where nome=@nome and senha=@senha";
            comm.CommandType = CommandType.Text;


            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;


            try
            {

                DR = comm.ExecuteReader();
                resp = DR.HasRows;

                Conexao.fecharConexao();
            }

            catch (MySqlException)
            {
                MessageBox.Show("Banco de dados não conectado", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            return resp;


        }
        
    }
}


