using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MASYEV1
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        private CriptografarSenha b;
        SqlConnection con = Conecta.abrirConexao();
        public FrmLogin()
        {
            InitializeComponent();
            b = new CriptografarSenha();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conecta.abrirConexao();
            string usu = "select nome,senha from login where nome=@login and senha=@senha";
            SqlCommand cmd = new SqlCommand(usu, con);
            cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtLogin.Text.Trim();
            txtSenha.Text = b.Base64Encode(txtSenha.Text);
            string criptografada = txtSenha.Text;
            cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = criptografada;
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataReader login = cmd.ExecuteReader();
            if (login.HasRows)
            {
                this.Hide();
                FrmInicial ini = new FrmInicial();
                ini.Show();
                login.Close();
                Conecta.fecharConexao();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos! Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                login.Close();
                Conecta.fecharConexao();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
