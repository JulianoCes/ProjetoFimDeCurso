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
    public partial class FrmCadProduto : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        public void CarregaDgvProduto()
        {
            SqlConnection con = Conecta.abrirConexao();
            String query = "select * from produto";
            SqlCommand cmd = new SqlCommand(query, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable produto = new DataTable();
            da.Fill(produto);
            dgvProduto.DataSource = produto;
            Conecta.fecharConexao();
        }
        public void CarregaCbxTipo()
        {
            String pro = "SELECT Id, nome FROM produto";
            SqlCommand cmd = new SqlCommand(pro, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tipo");
            cbxTipo.ValueMember = "Id";
            cbxTipo.DisplayMember = "tipo";
            cbxTipo.DataSource = ds.Tables["tipo"];
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
                cmd.CommandText = "InserirProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", cbxTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                cmd.Parameters.Add("@valorcompra",SqlDbType.Decimal, 3).Value = txtValorCompra.Text;
                cmd.Parameters.Add("@Valorvenda", SqlDbType.Decimal, 3).Value = txtValorVenda.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvProduto();
                MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValorCompra.Text = "";
                txtValorVenda.Text = "";
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
                cmd.CommandText = "AtualizarProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@codigo", this.txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", this.cbxTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("quantidade", this.txtQuantidade.Text);
                cmd.Parameters.Add("@valocompra", SqlDbType.Decimal, 3).Value = txtValorCompra.Text;
                cmd.Parameters.Add("@Valorvenda", SqlDbType.Decimal, 3).Value = txtValorVenda.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvProduto();
                MessageBox.Show("Produto atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValorCompra.Text = "";
                txtValorVenda.Text = "";
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
                cmd.CommandText = "ExcluirProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvProduto();
                MessageBox.Show("Produto apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValorCompra.Text = "";
                txtValorVenda.Text = "";
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
                cmd.CommandText = "LocalizarProduto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", this.txtCodigo.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtCodigo.Text = rd["codigo"].ToString();
                    cbxTipo.Text = rd["tipo"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtQuantidade.Text = rd["quantidade"].ToString();
                    txtValorCompra.Text = rd["valor_compra"].ToString();
                    txtValorVenda.Text = rd["valor_venda"].ToString();
                    Conecta.fecharConexao();
                }
                else
                {
                    MessageBox.Show("Este registro não foi encontrado!", "Sem registro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conecta.fecharConexao();
                }
            }
            finally
            {
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtCodigo.Text = row.Cells[1].Value.ToString();
                cbxTipo.Text = row.Cells[2].Value.ToString();
                txtNome.Text = row.Cells[3].Value.ToString();
                txtQuantidade.Text = row.Cells[4].Value.ToString();
                txtValorCompra.Text = row.Cells[5].Value.ToString();
                txtValorVenda.Text = row.Cells[6].Value.ToString();
            }
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            CarregaDgvProduto();
        }
    }
}
