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
            SqlConnection con = Conecta.abrirConexao();
            String query = "select * from EstoqueFisico ";
            SqlCommand cmd = new SqlCommand(query, con);
            
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable compra = new DataTable();
            da.Fill(compra);
            DgvCaixaCompra.DataSource = compra;
            Conecta.fecharConexao();

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
            cmd.CommandText = "LocalizarProduto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", cbxCodigo.Text);
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
            if (cbxCodigo.Text == "" && cbxTipo.Text == "" && cbxNomeProduto.Text == "" && cbxMarcaProduto.Text == "")
            {
                CarregacbxCodigo();
                CarregacbxTipo();
                CarregacbxNomeProduto();
                CarregacbxMarcaProduto();
            }
            else
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizaCompraDV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", this.cbxCodigo.Text);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtUsuario.Text = reader[1].ToString();
                    reader.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DgvCaixaCompra.DataSource = ds.Tables[0];
                    ds.Dispose();
                    Conecta.fecharConexao();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Dispose();
                    Conecta.fecharConexao();
                    cbxCodigo.Text = "";
                    CarregacbxCodigo();
                }
                CarregacbxTipo();
                CarregacbxNomeProduto();
                CarregacbxMarcaProduto();
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conecta.abrirConexao();
            SqlCommand compra = new SqlCommand("InserirCompraEstoque", con);
            compra.CommandType = CommandType.StoredProcedure;
            compra.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(txtId.Text);
            compra.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = txtUsuario.Text;
            compra.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(txtQuantidade.Text);
            compra.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
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

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("LocalizarProduto", con);
            cmd.Parameters.AddWithValue("@codigo", cbxCodigo.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conecta.abrirConexao();
            cmd.ExecuteNonQuery();
            Conecta.fecharConexao(); 
        }
    }
}
