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
    public partial class FrmCaixaVenda : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        List<Produto> plista = null;
        public FrmCaixaVenda()
        {
            InitializeComponent();
            
        }
        static int botaoclicado = 0;
        public void CarregaDgvCaixaVenda()
        {
            try
            {
                plista = new List<Produto>();
                SqlConnection con = Conecta.abrirConexao();
                string pedi = "select  Id as ID, codigo as Codigo, tipo as Tipo, nome as Nome, quantidade_Kg as Pesso_Kg, valor as Valor, usuario as Usuario, valortotal as Valor_total from ItemVendaBalanca";
                SqlCommand cmd = new SqlCommand(pedi, con);
                Conecta.abrirConexao();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable venda = new DataTable();
                da.Fill(venda);
                dgvCaixaVenda.DataSource = venda;
                Conecta.fecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void FrmCaixaVenda_Load(object sender, EventArgs e)
        {
            CarregaDgvCaixaVenda();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarItemVenda";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvCaixaVenda.DataSource = ds.Tables[0];
                    ds.Dispose();
                }
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtCodigo.Text = rd["codigo"].ToString();
                    txtTipo.Text = rd["tipo"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtQuantidade.Text = rd["quantidade_Kg"].ToString();
                    txtValor.Text = rd["valor"].ToString();
                    txtUsuario.Text = rd["usuario"].ToString();
                    txtValorTotal.Text = rd["valortotal"].ToString();
                    rd.Close();
                    Conecta.fecharConexao();
                    rd.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvCaixaVenda.DataSource = null;
                    Conecta.fecharConexao();
                    txtId.Text = "";
                    txtCodigo.Text = "";
                    txtTipo.Text = "";
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    txtValor.Text = "";
                    txtValorTotal.Text = "";
                    rd.Close();

                }
                Conecta.fecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dgvCaixaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvCaixaVenda.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtCodigo.Text = row.Cells[1].Value.ToString();
                txtTipo.Text = row.Cells[2].Value.ToString();
                txtNome.Text = row.Cells[3].Value.ToString();
                txtQuantidade.Text = row.Cells[4].Value.ToString();
                txtValor.Text = row.Cells[5].Value.ToString();
                txtUsuario.Text = row.Cells[6].Value.ToString();
                txtValorTotal.Text = row.Cells[7].Value.ToString();
                int linha = dgvCaixaVenda.CurrentRow.Index;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (botaoclicado == 1)
                {
                    SqlCommand novavenda = new SqlCommand("InserirItemVendaBalanca1", con);
                    novavenda.CommandType = CommandType.StoredProcedure;
                    novavenda.Parameters.AddWithValue("@codigo", SqlDbType.NChar).Value = txtCodigo.Text;
                    novavenda.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = txtTipo.Text;
                    novavenda.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                    novavenda.Parameters.AddWithValue("@quantidade", SqlDbType.Float).Value = Convert.ToInt32(txtQuantidade.Text);
                    novavenda.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
                    novavenda.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = txtUsuario.Text;
                    novavenda.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                    novavenda.Parameters.AddWithValue("@datavenda", SqlDbType.DateTime).Value = DateTime.Now;
                    Conecta.abrirConexao();
                    novavenda.ExecuteNonQuery();
                    Conecta.fecharConexao();
                    MessageBox.Show("Pedido atualizado!", "Atualizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botaoclicado = 0;
                }
                else
                {
                    DataGridViewRow novavenda1 = new DataGridViewRow();
                    novavenda1.CreateCells(dgvCaixaVenda);
                    novavenda1.Cells[0].Value = txtId.Text;
                    novavenda1.Cells[1].Value = txtCodigo.Text;
                    novavenda1.Cells[2].Value = txtTipo.Text;
                    novavenda1.Cells[3].Value = txtNome.Text;
                    novavenda1.Cells[4].Value = txtQuantidade.Text;
                    novavenda1.Cells[5].Value = txtValor.Text;
                    novavenda1.Cells[6].Value = txtUsuario.Text;
                    novavenda1.Cells[7].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                    dgvCaixaVenda.Rows.Add(novavenda1);
                    txtCodigo.Text = "";
                    txtTipo.Text = "";
                    txtNome.Text = "";
                    txtQuantidade.Text = "";
                    txtValor.Text = "";
                    decimal soma = 0;
                    foreach (DataGridViewRow dr in dgvCaixaVenda.Rows)
                        soma += Convert.ToDecimal(dr.Cells[7].Value);
                    txtValorTotal.Text = Convert.ToString(soma);
                    Conecta.fecharConexao();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dgvCaixaVenda.CurrentRow.Index;
                dgvCaixaVenda.Rows[linha].Cells[0].Value = txtId.Text;
                dgvCaixaVenda.Rows[linha].Cells[1].Value = txtCodigo.Text;
                dgvCaixaVenda.Rows[linha].Cells[2].Value = txtTipo.Text;
                dgvCaixaVenda.Rows[linha].Cells[3].Value = txtNome.Text;
                dgvCaixaVenda.Rows[linha].Cells[4].Value = txtQuantidade.Text;
                dgvCaixaVenda.Rows[linha].Cells[5].Value = txtValor.Text;
                dgvCaixaVenda.Rows[linha].Cells[6].Value = txtUsuario.Text;
                dgvCaixaVenda.Rows[linha].Cells[7].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvCaixaVenda.Rows)
                    soma += Convert.ToDecimal(dr.Cells[7].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dgvCaixaVenda.CurrentRow.Index;
                string query = "DELETE FROM ItemVendaBalanca WHERE (id = @id)";
                SqlCommand cmd = new SqlCommand(query, con);
                DataGridViewRow row = dgvCaixaVenda.Rows[linha];
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                Conecta.fecharConexao();
                dgvCaixaVenda.Rows.RemoveAt(linha);
                dgvCaixaVenda.Refresh();
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvCaixaVenda.Rows)
                    soma += Convert.ToDecimal(dr.Cells[7].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dgvCaixaVenda.Rows)
                {
                    SqlCommand venda = new SqlCommand("InserirVenda", con);
                    venda.CommandType = CommandType.StoredProcedure;
                    venda.Parameters.AddWithValue("@codigo", SqlDbType.NChar).Value = dr.Cells[1].Value;
                    venda.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = dr.Cells[2].Value;
                    venda.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = dr.Cells[3].Value;
                    venda.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[4].Value);
                    venda.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(dr.Cells[5].Value);
                    venda.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = dr.Cells[6].Value;
                    venda.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(dr.Cells[7].Value);
                    venda.Parameters.AddWithValue("@datavenda", SqlDbType.DateTime).Value = DateTime.Now;
                    Conecta.abrirConexao();
                    venda.ExecuteNonQuery();
                    Conecta.fecharConexao();
                }
                MessageBox.Show("Venda finalizada com sucesso!", "venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpar o datagrid pedido
                 dgvCaixaVenda.Rows.Clear();
                 dgvCaixaVenda.Refresh();
                int linha = dgvCaixaVenda.CurrentRow.Index;
                string query = "DELETE FROM ItemVendaBalanca WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                DataGridViewRow row = dgvCaixaVenda.Rows[linha];
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                Conecta.fecharConexao();
                dgvCaixaVenda.Rows.RemoveAt(linha);
                dgvCaixaVenda.Refresh();
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvCaixaVenda.Rows)
                    soma += Convert.ToDecimal(dr.Cells[7].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
