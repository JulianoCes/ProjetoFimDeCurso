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
    public partial class FrmCadCliente : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        public void CarregaDgvCliente()
        {
            SqlConnection con = Conecta.abrirConexao();
            String query = "select * from Cliente";
            SqlCommand cmd = new SqlCommand(query, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clie = new DataTable();
            da.Fill(clie);
            dgvCliente.DataSource = clie;
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
                cmd.CommandText = "IserirCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.Add("@data_nascimento", SqlDbType.Date, 31).Value = dateTimePicker1.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCliente();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                dateTimePicker1.Text = "";
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
                cmd.CommandText = "AtualizarCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", this.txtCpf.Text);
                cmd.Parameters.AddWithValue("@endereco", this.txtEndereco.Text);
                cmd.Parameters.AddWithValue("@telefone", this.txtTelefone.Text);
                cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
                cmd.Parameters.Add("@data_nascimento", SqlDbType.Date, 31).Value = dateTimePicker1.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCliente();
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                dateTimePicker1.Text = "";
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
                cmd.CommandText = "ExcluirCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCliente();
                MessageBox.Show("Cliente apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                dateTimePicker1.Text = "";
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
                cmd.CommandText = "LocalizarCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cpf", this.txtCpf.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtCpf.Text = rd["cpf"].ToString();
                    txtEndereco.Text = rd["endereco"].ToString();
                    txtTelefone.Text = rd["telefone"].ToString();
                    txtEmail.Text = rd["email"].ToString();
                    dateTimePicker1.Text = rd["data_nascimento"].ToString();
                    Conecta.fecharConexao();
                }
                else
                {
                    MessageBox.Show("Este Cliente não foi encontrado en nosa !", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conecta.fecharConexao();
                }
            }
            finally
            {
            }
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            CarregaDgvCliente();
        }

        private void dgvCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCpf.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                txtTelefone.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
