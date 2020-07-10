using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASYEV1
{
    public partial class FrmRelCliente : MetroFramework.Forms.MetroForm
    {
        public FrmRelCliente()
        {
            InitializeComponent();
        }

        private void FrmRelCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBcasa_carneDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.DBcasa_carneDataSet1.Cliente);

            this.RelCliente.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
