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

        public void CarregaDgvProduto()
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

        public void CarregaCbxTipo()
        {
            String pro = "SELECT Id, nome FROM EstoqueFisico";
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

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InserirEstoque";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", cbxTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", txtnome);
                cmd.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal, 3).Value = txtvalor;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvProduto();
                MessageBox.Show("Produto inserido en estoque com sucesso!", "Cadastro", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                //txtId.Text = "";
                txtCodigo.Text = "";
                cbxTipo.Text = "";
                txtnome.Text = "";
                txtquantidade.Text = "";
                txtvalor.Text = "";
                txtValorTotal.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conecta.abrirConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "AtualizarEstoque";
                cmd.CommandType = CommandType.StoredProcedure;
               // cmd.Parameters.AddWithValue("@id", this.txtId.Text);
                cmd.Parameters.AddWithValue("@codigo", this.txtCodigo.Text);
                cmd.Parameters.AddWithValue("@tipo", this.cbxTipo.Text);
                cmd.Parameters.AddWithValue("@Nome", this.txtnome.Text);
                cmd.Parameters.AddWithValue("quantidade", this.txtquantidade.Text);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal, 3).Value = txtvalor.Text;
                //cmd.Parameters.Add("@Valorvenda", SqlDbType.Decimal, 3).Value = txtValorTotal.Text;
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                CarregaDgvProduto();
                MessageBox.Show("Produto atualizado com sucesso!", "Atualiza", MessageBoxButtons.OK);
                Conecta.fecharConexao();
                //txtId.Text = "";
                txtCodigo.Text = "";
                cbxTipo.Text = "";
                txtnome.Text = "";
                txtquantidade.Text = "";
                txtvalor.Text = "";
                txtValorTotal.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
