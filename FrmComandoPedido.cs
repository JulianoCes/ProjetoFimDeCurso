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
    public partial class FrmComandoPedido : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Conecta.abrirConexao();
        public FrmComandoPedido()
        {
            InitializeComponent();
        }

        public string codigo { get; set; }

        private void FrmComandoPedido_Load(object sender, EventArgs e)
        {
            if (!this.Equals(""))
            {
                label1.Text = this.codigo;
            }
            string idpedido = "select max(Id) as Id from PedidoDelivery where codigo = @Codigo";
            SqlCommand cmd = new SqlCommand(idpedido, con);
            cmd.Parameters.AddWithValue("@codigo", label1.Text.Trim());
            Conecta.abrirConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                label2.Text = rd["Id"].ToString();
            }
            this.reportViewer1.RefreshReport();
        }

       
    }
}
