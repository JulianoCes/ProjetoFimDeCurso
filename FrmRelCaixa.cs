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
    public partial class FrmRelCaixa : MetroFramework.Forms.MetroForm
    {
        public FrmRelCaixa()
        {
            InitializeComponent();
        }

        private void FrmRelCaixa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBcasa_carneDataSet2.CaixaVenda'. Você pode movê-la ou removê-la conforme necessário.
            this.CaixaVendaTableAdapter.Fill(this.DBcasa_carneDataSet2.CaixaVenda);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
