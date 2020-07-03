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
    public partial class FrmCadFornecedor : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        public void CarregaDgvFornecedor()
        {
            SqlConnection con = Conecta.abrirConexao();
            String query = "select * from Fornecedor";
            SqlCommand cmd = new SqlCommand(query, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable forne = new DataTable();
            da.Fill(forne);
            dgvFornecedor.DataSource = forne;
            Conecta.fecharConexao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInseri_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@fone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.Add("@data", SqlDbType.Date, 31).Value = dtpData.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvFornecedor();
                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCnpj.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                dtpData.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("@cnpj", this.txtCnpj.Text);
                cmd.Parameters.AddWithValue("@endereco", this.txtEndereco.Text);
                cmd.Parameters.AddWithValue("@fone", this.txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
                cmd.Parameters.Add("@data", SqlDbType.Date, 31).Value = dtpData.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvFornecedor();
                MessageBox.Show("Fornecedor atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCnpj.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                dtpData.Text = "";
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
                cmd.CommandText = "ExcluirFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvFornecedor();
                MessageBox.Show("Fornecedor apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCnpj.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                dtpData.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cnpj", this.txtCnpj.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtCnpj.Text = rd["cnpj"].ToString();
                    txtEndereco.Text = rd["endereco"].ToString();
                    txtTelefone.Text = rd["telefone"].ToString();
                    txtEmail.Text = rd["email"].ToString();
                    dtpData.Text = rd["data"].ToString();
                    Conecta.fecharConexao();
                }
                else
                {
                    MessageBox.Show("Este fornecedor não foi encontrado em nossa base de dados !", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conecta.fecharConexao();
                }
            }
            finally
            {
            }
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFornecedor.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCnpj.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                txtTelefone.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                dtpData.Text = row.Cells[6].Value.ToString();
            }
        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            CarregaDgvFornecedor();
        }
    }
}
