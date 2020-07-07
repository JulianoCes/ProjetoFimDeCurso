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
        private CriptografarSenha s;
        SqlConnection con = Conecta.abrirConexao();
        public FrmLogin()
        {
            InitializeComponent();
            s = new CriptografarSenha();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conecta.abrirConexao();
            string usu = "select usuario,senha from login where usuario=@login and senha=@senha";
            SqlCommand cmd = new SqlCommand(usu, con);
            cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = txtLogin.Text.Trim();
            txtSenha.Text = s.Base64Encode(txtSenha.Text);
            string criptografada = txtSenha.Text;
            cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = criptografada;
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataReader usuario = cmd.ExecuteReader();
            if (usuario.HasRows)
            {
                this.Hide();
                FrmInicial ini = new FrmInicial();
                ini.Show();
                usuario.Close();
                Conecta.fecharConexao();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos! Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                usuario.Close();
                Conecta.fecharConexao();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
