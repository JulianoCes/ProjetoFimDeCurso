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
    public partial class FrmCadUsuario : MetroFramework.Forms.MetroForm
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }
        //criando o metodo para carregar o gride
        public void CarregaDgvUsuario()
        {
            SqlConnection con = Conecta.abrirConexao();
            String query = "select * from usuario";
            SqlCommand cmd = new SqlCommand(query, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable produto = new DataTable();
            da.Fill(produto);
            DgvUsuario.DataSource = produto;
            Conecta.fecharConexao();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            CarregaDgvUsuario();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@fone", txtFone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@funcao", txtFuncao.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvUsuario();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtFone.Text = "";
                txtEmail.Text = "";
                txtFuncao.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", this.txtCpf.Text);
                cmd.Parameters.AddWithValue("@fone", this.txtFone.Text);
                cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
                cmd.Parameters.AddWithValue("@funcao", this.txtFuncao.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvUsuario();
                MessageBox.Show("Registro atualizado com sucesso!", "Atualizar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtFone.Text = "";
                txtEmail.Text = "";
                txtFuncao.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvUsuario();
                MessageBox.Show("Registro apagado com sucesso!", "Excluir Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtFone.Text = "";
                txtEmail.Text = "";
                txtFuncao.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtCpf.Text = rd["cpf"].ToString();
                    txtFone.Text = rd["fone"].ToString();
                    txtEmail.Text = rd["email"].ToString();
                    txtFuncao.Text = rd["funcao"].ToString();
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

        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvUsuario.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCpf.Text = row.Cells[2].Value.ToString();
                txtFone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtFuncao.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}

