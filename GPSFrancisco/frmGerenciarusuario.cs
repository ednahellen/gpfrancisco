using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmGerenciarusuario : Form
    {
        public frmGerenciarusuario()
        {
            InitializeComponent();
            desabilitarCampos();
            

        }

        public void desabilitarCampos()
        {
            txtUsu.Enabled = false;
            txtSenha.Enabled = false;
            txtValsenha.Enabled = false;
            btCadastrar.Enabled = false;
            btLimpar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtUsu.Enabled = true;
            txtSenha.Enabled = true;
            txtValsenha.Enabled = true;
            btCadastrar.Enabled = true;
            btAlterar.Enabled = true;
            btExcluir.Enabled = true;
            btLimpar.Enabled = true;
            btNovo.Enabled = true;
            txtSenha.Focus();

        }

        public void habilitarCamposCadastrar() 
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

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //criando o método para limpar os campos
        public void LimparCampos()
        {
            txtCod.Clear();
            txtUsu.Clear();
            txtSenha.Clear();
            txtValsenha.Clear();
            txtUsu.Focus();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text.Equals("") || txtSenha.Text.Equals("") || txtValsenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos",
                 "Mensagem do sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1
             ); LimparCampos();


            }
            else
            {
                if (txtSenha.Text.Length < 12 || txtValsenha.Text.Length < 12)
                {
                    MessageBox.Show("A senha deve ter no mínimo 12 caracteres",
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
                        MessageBox.Show("Cadastro realizado com sucesso",
                         "Mensagem do sistema",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("As senhas não conferem",
                         "Mensagem do sistema",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error,
                         MessageBoxDefaultButton.Button1
                     ); LimparCampos();
                    }
                }
            }
        }

        private void txtValsenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtValsenha.Text)
            {
                btChecked.Visible = false;
                btRedchecked.Visible = true;

            }

            else
            {
                if (txtSenha.Text.Equals(txtValsenha.Text)) && txtSenha.Text.Length < 12 && txtValsenha.Text.Length < 12)
                {
                    btChecked.Visible = true;
                    btRedchecked.Visible = false;
                }
                else 
                {
                    MessageBox.Show("As senhas não conferem",
                     "Mensagem do sistema",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1); 
                    LimparCampos();
                }
            }                

        }
    }
}

