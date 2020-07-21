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
                String query = "select * from EstoqueFisico  ";
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
        private void bntLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarEstoqueFisico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    cbxCodigo.Text = rd["codigo"].ToString();
                    cbxTipo.Text = rd["tipo"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    cbxMarcaProduto.Text = rd["marca"].ToString();
                    txtQuantidade.Text = rd["quantidade"].ToString();
                    txtValor.Text = rd["valor"].ToString();
                    txtUsuario.Text = rd["usuario"].ToString();
                    txtValorTotal.Text = rd["valortotal"].ToString();
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
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirCompraEstoque";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", cbxCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", cbxTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@marca", cbxMarcaProduto.Text);
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                cmd.Parameters.AddWithValue("@datacompra", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaCompra();
                MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxMarcaProduto.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                txtValorTotal.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
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
                    txtNome.Text = row.Cells[3].Value.ToString();
                    cbxMarcaProduto.Text = row.Cells[4].Value.ToString();
                    txtQuantidade.Text = row.Cells[5].Value.ToString();
                    txtValor.Text = row.Cells[6].Value.ToString();
                    txtUsuario.Text = row.Cells[7].Value.ToString();
                    txtValorTotal.Text = row.Cells[8].Value.ToString();
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
                cmd.Parameters.AddWithValue("@Nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("@marca", this.cbxMarcaProduto.Text);
                cmd.Parameters.AddWithValue("@quantidade", this.txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(this.txtValor.Text);
                cmd.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = this.txtUsuario.Text;
                cmd.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(this.txtQuantidade.Text) * Convert.ToDecimal(this.txtValor.Text);
                cmd.Parameters.AddWithValue("@datacompra", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaCompra();
                MessageBox.Show("Produto atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxMarcaProduto.Text = "";
                txtQuantidade.Text = "";
                txtUsuario.Text = "";
                txtValor.Text = "";
                txtValorTotal.Text = "";
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
                cmd.CommandText = "ExcluirCompraEstoque";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaCompra();
                MessageBox.Show("Produto apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                cbxCodigo.Text = "";
                cbxTipo.Text = "";
                txtNome.Text = "";
                cbxMarcaProduto.Text = "";
                txtQuantidade.Text = "";
                txtUsuario.Text = "";
                txtValor.Text = "";
                txtValorTotal.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

       
    }
}
