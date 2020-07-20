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
using System.Data.SqlTypes;

namespace MASYEV1
{
    public partial class FrmCaixaCompra : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        public FrmCaixaCompra()
        {
            InitializeComponent();
        }
        public void CarregaDgvCaixaCompra()
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                String query = "select * from produto  ";
                SqlCommand cmd = new SqlCommand(query, con);
                Conecta.abrirConexao();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable compra = new DataTable();
                da.Fill(compra);
                DgvCaixaCompra.DataSource = compra;
                Conecta.fecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        public void CarregacbxCodigo()
        {
            string codigo = "select * from produto";
            SqlCommand cmd = new SqlCommand(codigo, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(codigo, con);
            DataSet ds = new DataSet();
            cbxCodigo.ValueMember = "Id";
            cbxCodigo.DisplayMember = "codigo";
            cbxCodigo.DataSource = ds.Tables["codigo"];
            ds.Dispose();
            Conecta.fecharConexao();
        }

        public void CarregacbxTipo()
        {
            string tipo = "select * from produto";
            SqlCommand cmd = new SqlCommand(tipo, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(tipo, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tipo");
            cbxTipo.ValueMember = "Id";
            cbxTipo.DisplayMember = "tipo";
            cbxTipo.DataSource = ds.Tables["tipo"];
            ds.Dispose();
            Conecta.fecharConexao();
        }

        public void CarregacbxNomeProduto()
        {
            string nome = "select * from produto";
            SqlCommand cmd = new SqlCommand(nome, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(nome, con);
            DataSet ds = new DataSet();
            cbxNomeProduto.ValueMember = "Id";
            cbxNomeProduto.DisplayMember = "nome";
            cbxNomeProduto.DataSource = ds.Tables["nome"];
            ds.Dispose();
            Conecta.fecharConexao();
        }

        public void CarregacbxMarcaProduto()
        {
            string marca = "select * from produto";
            SqlCommand cmd = new SqlCommand(marca, con);
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(marca, con);
            DataSet ds = new DataSet();
            cbxNomeProduto.ValueMember = "Id";
            cbxNomeProduto.DisplayMember = "marca";
            cbxNomeProduto.DataSource = ds.Tables["marca"];
            ds.Dispose();
            Conecta.fecharConexao();
        }

        private void bntLocalizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conecta.abrirConexao();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "LocalizarEstoqueFisico";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@codigo", cbxCodigo.Text);
            cmd.Parameters.AddWithValue("@nome", cbxNomeProduto.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);
             if (ds.Tables[0].Rows.Count > 0)
             {
                 DgvCaixaCompra.DataSource = ds.Tables[0];
                 ds.Dispose();
             }
            Conecta.abrirConexao();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtId.Text = rd["Id"].ToString();
                cbxCodigo.Text = rd["codigo"].ToString();
                cbxTipo.Text = rd["tipo"].ToString();
                cbxNomeProduto.Text = rd["nome"].ToString();
                cbxMarcaProduto.Text = rd["marca"].ToString();
                txtQuantidade.Text = rd["quantidade"].ToString();
                txtUsuario.Text = rd["usuario"].ToString();
                txtValor.Text = rd["valor"].ToString();
                Conecta.fecharConexao();
                rd.Close();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DgvCaixaCompra.DataSource = null;
                Conecta.fecharConexao();
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                cbxNomeProduto.Text = "";
                cbxMarcaProduto.Text = "";
                CarregacbxCodigo();
                CarregacbxTipo();
                CarregacbxNomeProduto();
                CarregacbxMarcaProduto();
                CarregaDgvCaixaCompra();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCaixaCompra_Load(object sender, EventArgs e)
        {
            CarregaDgvCaixaCompra();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand compra = new SqlCommand("InserirCompraEstoque", con);
                compra.CommandType = CommandType.StoredProcedure;
                compra.Parameters.AddWithValue("@codigo", SqlDbType.Int).Value = cbxCodigo;
                compra.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = cbxTipo;
                compra.Parameters.AddWithValue("@nome", SqlDbType.Int).Value = cbxNomeProduto;
                compra.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(txtQuantidade.Text);
                compra.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
                compra.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = txtUsuario.Text;
                compra.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                compra.Parameters.AddWithValue("@datacompra", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                compra.ExecuteNonQuery();
                Conecta.fecharConexao();
                MessageBox.Show("Produto inserido no estoque!", "Atualizar Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                cbxNomeProduto.Text = "";
                cbxMarcaProduto.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LocalizarProduto", con);
            cmd.Parameters.AddWithValue("@codigo", cbxCodigo.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conecta.abrirConexao();
            cmd.ExecuteNonQuery();
            Conecta.fecharConexao(); 
        }

        private void DgvCaixaCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DgvCaixaCompra.Rows[e.RowIndex];
                    txtId.Text = row.Cells[0].Value.ToString();
                    cbxCodigo.Text = row.Cells[1].Value.ToString();
                    cbxTipo.Text = row.Cells[2].Value.ToString();
                    cbxNomeProduto.Text = row.Cells[3].Value.ToString();
                    cbxMarcaProduto.Text = row.Cells[4].Value.ToString();
                    txtUsuario.Text = row.Cells[5].Value.ToString();
                    txtValor.Text = row.Cells[6].Value.ToString();
                }
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
                cmd.CommandText = "AtualizarCompraEstoque";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@codigo", this.cbxCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", this.cbxTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", this.cbxNomeProduto.Text);
                cmd.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
                cmd.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = txtUsuario.Text;
                cmd.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                cmd.Parameters.AddWithValue("@datacompra", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaCompra();
                MessageBox.Show("Produto atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                cbxNomeProduto.Text = "";
                txtQuantidade.Text = "";
                txtUsuario.Text = "";
                txtValor.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
