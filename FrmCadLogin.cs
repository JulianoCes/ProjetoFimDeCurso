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
    public partial class FrmCadLogin : MetroFramework.Forms.MetroForm
    {
        private CriptografarSenha b;
        SqlConnection con = Conecta.abrirConexao();
        public FrmCadLogin()
        {
            InitializeComponent();
            b = new CriptografarSenha();
        }
        //criando o metodo para carregar o gride
        public void CarregaDgvlogin()
        {
            SqlConnection con = Conecta.abrirConexao();
            String query = "select Id, cpf, nome from Login";
            SqlCommand cmd = new SqlCommand(query, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable login = new DataTable();
            da.Fill(login);
            DgvLogim.DataSource = login;
            Conecta.fecharConexao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //codigo para inserir o login no banco
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                //codificando txtsenha.
                txtSenha.Text = b.Base64Encode(txtSenha.Text);
                //nova variavel para atribuo o txtSenha nela.
                string criptografada = txtSenha.Text;
                //o parametro gravar a senha decodificada já no banco.
                cmd.Parameters.AddWithValue("@senha", criptografada);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvlogin();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCpf.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //codigo para atualizar os dados do login
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@cpf", this.txtCpf.Text);
                cmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                //cmd.Parameters.AddWithValue("@senha", this.txtSenha.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvlogin();
                MessageBox.Show("Registro atualizado com sucesso!", "Atualizar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCpf.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvlogin();
                MessageBox.Show("Registro apagado com sucesso!", "Excluir Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCpf.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", this.txtCpf.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtCpf.Text = rd["cpf"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    Conecta.fecharConexao();
                    rd.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conecta.fecharConexao();
                }
            }
            finally
            {
            }
        }

        private void DgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvLogim.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtCpf.Text = row.Cells[1].Value.ToString();
                txtNome.Text = row.Cells[2].Value.ToString();
            }
        }

        private void FrmCadLogin_Load(object sender, EventArgs e)
        {
            CarregaDgvlogin();
        }
    }
}
