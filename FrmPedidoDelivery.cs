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

        }

      
    }
}
