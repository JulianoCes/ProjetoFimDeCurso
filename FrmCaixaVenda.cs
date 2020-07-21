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
        
        public FrmCaixaVenda()
        {
            InitializeComponent();

        }
        public void CarregaDgvCaixaVenda()
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                string pedi = "select * from ItemVendaBalanca";
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
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@codigo", this.txtCodigo.Text);
                cmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                Conecta.abrirConexao();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txtId.Text = rd["Id"].ToString();
                    txtCodigo.Text = rd["codigo"].ToString();
                    txtTipo.Text = rd["tipo"].ToString();
                    txtNome.Text = rd["nome"].ToString();
                    txtCorte.Text = rd["corte"].ToString();
                    txtQuantidade.Text = rd["quantidade_Kg"].ToString();
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

        private void dgvCaixaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvCaixaVenda.Rows[e.RowIndex];
                    txtId.Text = row.Cells[0].Value.ToString();
                    txtCodigo.Text = row.Cells[1].Value.ToString();
                    txtTipo.Text = row.Cells[2].Value.ToString();
                    txtNome.Text = row.Cells[3].Value.ToString();
                    txtCorte.Text = row.Cells[4].Value.ToString();
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

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirItemVendaBalanca";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@corte", txtCorte.Text);
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                cmd.Parameters.AddWithValue("@datavenda", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaVenda();
                MessageBox.Show("Produto adicionado com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtCorte.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";
                txtValorTotal.Text = "";
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
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarItemBalanca";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@codigo", this.txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", this.txtTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", this.txtNome.Text);
                cmd.Parameters.AddWithValue("@corte", this.txtCorte.Text);
                cmd.Parameters.AddWithValue("@quantidade", this.txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@valor", SqlDbType.Int).Value = Convert.ToDecimal(this.txtValor.Text);
                cmd.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = this.txtUsuario.Text;
                cmd.Parameters.AddWithValue("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(this.txtQuantidade.Text) * Convert.ToDecimal(this.txtValor.Text);
                cmd.Parameters.AddWithValue("@datavenda", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaVenda();
                MessageBox.Show("Produto atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtCorte.Text = "";
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

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "ExcluirItemBalanca";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvCaixaVenda();
                MessageBox.Show("Produto apagado com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtCorte.Text = "";
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

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "VendaFinalizada";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@corte", txtCorte.Text);
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                cmd.Parameters.Add("@valor", SqlDbType.Int).Value = Convert.ToDecimal(txtValor.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.Add("@valortotal", SqlDbType.Int).Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
                cmd.Parameters.Add("@datavendido", SqlDbType.DateTime).Value = DateTime.Now;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                Conecta.fecharConexao();
                SqlCommand cmdo = con.CreateCommand();
                cmdo.CommandText = "ExcluirItemBalanca";
                cmdo.CommandType = CommandType.StoredProcedure;
                cmdo.Parameters.AddWithValue("@Id", this.txtId.Text);
                Conecta.abrirConexao();
                cmdo.ExecuteNonQuery();
                CarregaDgvCaixaVenda();
                MessageBox.Show("Venda finalizada com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                txtId.Text = "";
                txtCodigo.Text = "";
                txtTipo.Text = "";
                txtNome.Text = "";
                txtCorte.Text = "";
                txtQuantidade.Text = "";
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
