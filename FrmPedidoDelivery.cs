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
    public partial class FrmPedidoDelivery : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        public FrmPedidoDelivery()
        {
            InitializeComponent();
        }
        static int botaoclicado = 0;
       



        public void CarregaCbxCodigo()
        {
            String pro = "SELECT Id, codigo FROM PedidoDelivery";
            SqlCommand cmd = new SqlCommand(pro, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "codigo");
            cbxCodigo.ValueMember = "Id";
            cbxCodigo.DisplayMember = "codigo";
            cbxCodigo.DataSource = ds.Tables["codigo"];
            Conecta.fecharConexao();
        }
        public void CarregaCbxTipo()
        {
            String pro = "SELECT Id, codigo FROM PedidoDelivery ";
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
        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LocalizarEstoqueFisico", con);
            cmd.Parameters.AddWithValue("@Id", cbxCodigo.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conecta.abrirConexao();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtUsuario.Text = rd["usuario"].ToString();
                rd.Close();
                Conecta.fecharConexao();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Falha na Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rd.Close();
                Conecta.fecharConexao();
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LocalizarEstoqueFisico", con);
            cmd.Parameters.AddWithValue("@tipo", cbxTipo.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conecta.abrirConexao();
           
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (botaoclicado == 0)
                {
                    SqlCommand pedidos = new SqlCommand("Inserirpedido", con);
                    pedidos.CommandType = CommandType.StoredProcedure;
                    pedidos.Parameters.AddWithValue("@codigo", SqlDbType.NChar).Value = cbxCodigo.Text;
                    pedidos.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = cbxTipo.Text;
                    pedidos.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                    pedidos.Parameters.AddWithValue("@corte", SqlDbType.NChar).Value = cbxCorte.Text;
                    pedidos.Parameters.AddWithValue("@quantidade", SqlDbType.Float).Value = Convert.ToInt32(txtQuantidade.Text);
                    pedidos.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
                    pedidos.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = txtUsuario.Text;
                    pedidos.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                    pedidos.Parameters.AddWithValue("@datapedido", SqlDbType.DateTime).Value = DateTime.Now;
                    Conecta.abrirConexao();
                    pedidos.ExecuteNonQuery();
                    Conecta.fecharConexao();
                    MessageBox.Show("Pedido Adicionado!", "Adicionar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvPedidoDelivery);
                item.Cells[0].Value = txtId.Text;
                item.Cells[1].Value = cbxCodigo.Text;
                item.Cells[2].Value = cbxTipo.Text;
                item.Cells[3].Value = txtNome.Text;
                item.Cells[4].Value = cbxCorte.Text;
                item.Cells[5].Value = txtQuantidade.Text;
                item.Cells[6].Value = txtValor.Text;
                item.Cells[7].Value = txtUsuario.Text;
                item.Cells[8].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvPedidoDelivery.Rows.Add(item);
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedidoDelivery.Rows)
                    soma += Convert.ToDecimal(dr.Cells[8].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                Conecta.fecharConexao();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
                

        }

        private void bntLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Localizarpedido";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", cbxCodigo.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvPedidoDelivery.DataSource = ds.Tables[0];
                    ds.Dispose();
                }
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    //txtId.Text = rd["Id"].ToString();
                    cbxCodigo.Text = rd["codigo"].ToString();
                    cbxTipo.Text = rd["tipo"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    cbxCorte.Text = rd["corte"].ToString();
                    txtQuantidade.Text = rd["quantidade"].ToString();
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
                    dgvPedidoDelivery.DataSource = null;
                    Conecta.fecharConexao();
                    txtId.Text = "";
                    cbxCodigo.Text = "";
                    cbxTipo.Text = "";
                    txtNome.Text = "";
                    cbxCorte.Text = "";
                    txtQuantidade.Text = "";
                    txtValor.Text = "";
                    rd.Close();

                }
                Conecta.fecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void dgvPedidoDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvPedidoDelivery.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                cbxCodigo.Text = row.Cells[1].Value.ToString();
                cbxTipo.Text = row.Cells[2].Value.ToString();
                txtNome.Text = row.Cells[3].Value.ToString();
                cbxCorte.Text = row.Cells[4].Value.ToString();
                txtQuantidade.Text = row.Cells[5].Value.ToString();
                txtValor.Text = row.Cells[6].Value.ToString();
                txtUsuario.Text = row.Cells[7].Value.ToString();
                txtValorTotal.Text = row.Cells[8].Value.ToString();
                int linha = dgvPedidoDelivery.CurrentRow.Index;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dgvPedidoDelivery.CurrentRow.Index;
                dgvPedidoDelivery.Rows[linha].Cells[0].Value = txtId.Text;
                dgvPedidoDelivery.Rows[linha].Cells[1].Value = cbxCodigo.Text;
                dgvPedidoDelivery.Rows[linha].Cells[2].Value = cbxTipo.Text;
                dgvPedidoDelivery.Rows[linha].Cells[3].Value = txtNome.Text;
                dgvPedidoDelivery.Rows[linha].Cells[4].Value = cbxCorte.Text;
                dgvPedidoDelivery.Rows[linha].Cells[5].Value = txtQuantidade.Text;
                dgvPedidoDelivery.Rows[linha].Cells[6].Value = txtValor.Text;
                dgvPedidoDelivery.Rows[linha].Cells[7].Value = txtUsuario.Text;
                dgvPedidoDelivery.Rows[linha].Cells[8].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedidoDelivery.Rows)
                    soma += Convert.ToDecimal(dr.Cells[8].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
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
                int linha = dgvPedidoDelivery.CurrentRow.Index;
                string query = "DELETE FROM PedidoDelivery WHERE (id = @id)";
                SqlCommand cmd = new SqlCommand(query, con);
                DataGridViewRow row = dgvPedidoDelivery.Rows[linha];
                //cmd.Parameters.AddWithValue("@codigo", cbxCodigo.SelectedValue);
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                Conecta.fecharConexao();
                dgvPedidoDelivery.Rows.RemoveAt(linha);
                dgvPedidoDelivery.Refresh();
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedidoDelivery.Rows)
                    soma += Convert.ToDecimal(dr.Cells[8].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dgvPedidoDelivery.Rows)
                {
                    SqlCommand pedidos = new SqlCommand("InserirItemVendaBalanca", con);
                    pedidos.CommandType = CommandType.StoredProcedure;
                    //pedidos.Parameters.AddWithValue("@codigo", SqlDbType.Int).Value = cbxCodigo.SelectedValue;
                    pedidos.Parameters.AddWithValue("@codigo", SqlDbType.NChar).Value = (dr.Cells[1].Value);
                    pedidos.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = dr.Cells[2].Value;
                    pedidos.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = dr.Cells[3].Value;
                    pedidos.Parameters.AddWithValue("@corte", SqlDbType.NChar).Value = dr.Cells[4].Value;
                    pedidos.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[5].Value);
                    pedidos.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(dr.Cells[6].Value);
                    pedidos.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = dr.Cells[7].Value;
                    pedidos.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(dr.Cells[8].Value);
                    pedidos.Parameters.AddWithValue("@datavenda", SqlDbType.DateTime).Value = DateTime.Now;
                    Conecta.abrirConexao();
                    pedidos.ExecuteNonQuery();
                    Conecta.fecharConexao();
                }
                MessageBox.Show("Pedidos realizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                txtValorTotal.Text = "";

                //Limpar o datagrid pedido
               // dgvPedidoDelivery.Rows.Clear();
               // dgvPedidoDelivery.Refresh();
                int linha = dgvPedidoDelivery.CurrentRow.Index;
                string query = "DELETE FROM PedidoDelivery WHERE (id = @id)";
                SqlCommand cmd = new SqlCommand(query, con);
                DataGridViewRow row = dgvPedidoDelivery.Rows[linha];
                //cmd.Parameters.AddWithValue("@codigo", cbxCodigo.SelectedValue);
                cmd.Parameters.AddWithValue("@id", row.Cells[0].Value);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                Conecta.fecharConexao();
                dgvPedidoDelivery.Rows.RemoveAt(linha);
                dgvPedidoDelivery.Refresh();
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedidoDelivery.Rows)
                    soma += Convert.ToDecimal(dr.Cells[8].Value);
                txtValorTotal.Text = Convert.ToString(soma);
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
           
        }

        private void FrmPedidoDelivery_Load(object sender, EventArgs e)
        {
            //CarregaDgvPedidiDeliveri();
        }
    }
}
