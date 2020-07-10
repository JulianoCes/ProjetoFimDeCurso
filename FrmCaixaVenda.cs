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
               
                string pedi = "select  Id, codigo, nome, tipo, quantidade_Kg, valor, usuario, valortotal from ItemVendaBalanca";
                SqlCommand cmd = new SqlCommand(pedi, con);
                Conecta.abrirConexao();
                cmd.ExecuteNonQuery();
                /*SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtUsuario.Text = dr["usuario"].ToString();
                    dr.Close();
                    Conecta.fecharConexao();
                }*/
                dgvCaixaVenda.Columns.Add("Id", "ID");
                dgvCaixaVenda.Columns.Add("codigo", "Codigo");
                dgvCaixaVenda.Columns.Add("tipo", "Tipo");
                dgvCaixaVenda.Columns.Add("nome", "Nome");
               // dgvCaixaVenda.Columns.Add("corte", "corte");
                dgvCaixaVenda.Columns.Add("quantidade", "Quantidade");
                dgvCaixaVenda.Columns.Add("valor", "Valor");
                dgvCaixaVenda.Columns.Add("usuario", "Usuario");
                dgvCaixaVenda.Columns.Add("valortotal", "Total");
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
    }
}
