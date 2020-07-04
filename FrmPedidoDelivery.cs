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
        //static int botaoclicado = 0;
        public void CarregaDgvPedidoDelivery()
        {
            SqlConnection con = Conecta.abrirConexao();
            String query = "select * from PedidoDelivery";
            SqlCommand cmd = new SqlCommand(query, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable compra = new DataTable();
            da.Fill(compra);
            dgvPedidoDelivery.DataSource = compra;
            Conecta.fecharConexao();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            //if (botaoclicado == 1)
           // {
                SqlCommand pedidos = new SqlCommand("Inserirpedidos", con);
                pedidos.CommandType = CommandType.StoredProcedure;
                pedidos.Parameters.AddWithValue("@codigo", SqlDbType.NChar).Value = cbxCodigo.SelectedValue;
                pedidos.Parameters.AddWithValue("@tipo", SqlDbType.NChar).Value = cbxTipo.SelectedValue;
                pedidos.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtUsuario.Text;
                pedidos.Parameters.AddWithValue("@corte", SqlDbType.NChar).Value = cbxCorte.Text;
                pedidos.Parameters.AddWithValue("@quantidade", SqlDbType.Float).Value = Convert.ToInt32(txtQuantidade.Text);
                pedidos.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
                pedidos.Parameters.AddWithValue("@logado", SqlDbType.NChar).Value = txtUsuario.Text;
                pedidos.Parameters.AddWithValue("@total", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                pedidos.Parameters.AddWithValue("@dia_hora", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                pedidos.ExecuteNonQuery();
                Conecta.fecharConexao();
                MessageBox.Show("Pedido atualizado!", "Atualizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
               /* DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvPedidoDelivery);
                item.Cells[1].Value = cbxCodigo.Text;
                item.Cells[2].Value = cbxTipo.Text;
                item.Cells[3].Value = txtNome.Text;
                item.Cells[4].Value = cbxCorte.Text;
                item.Cells[5].Value = txtQuantidade.Text;
                item.Cells[6].Value = txtValor.Text;
                item.Cells[7].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvPedidoDelivery.Rows.Add(item);
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedidoDelivery.Rows)
                    soma += Convert.ToDecimal(dr.Cells[7].Value);
                txtValorTotal.Text = Convert.ToString(soma);*/
            
        }

        private void bntLocalizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conecta.abrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "LocalizaCompraDV";
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
                txtId.Text = rd["Id"].ToString();
                cbxCodigo.Text = rd["codigo"].ToString();
                cbxTipo.Text = rd["tipo"].ToString();
                txtNome.Text = rd["nome"].ToString();
                cbxCorte.Text = rd["marca"].ToString();
                txtValor.Text = rd["valor"].ToString();
                txtUsuario.Text = rd["usuario"].ToString();
                txtValorTotal.Text = rd["valortotal"].ToString();
                Conecta.fecharConexao();
                rd.Close();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvPedidoDelivery.DataSource = null;
                Conecta.fecharConexao();
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxCorte.Text = "";
              
            }
        }

        private void dgvPedidoDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPedidoDelivery.Rows[e.RowIndex];
            cbxCodigo.Text = row.Cells[1].Value.ToString();
            cbxTipo.Text = row.Cells[2].Value.ToString();
            txtNome.Text = row.Cells[3].Value.ToString();
            txtQuantidade.Text = row.Cells[3].Value.ToString();
            txtValor.Text = row.Cells[4].Value.ToString();
            int linha = dgvPedidoDelivery.CurrentRow.Index;
        }

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LocalizarProduto", con);
            cmd.Parameters.AddWithValue("@Id", cbxCodigo.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conecta.abrirConexao();
        }
    }
}
