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
    public partial class FrmRelusuario : MetroFramework.Forms.MetroForm
    {
        public FrmRelusuario()
        {
            InitializeComponent();
        }

        private void FrmRelusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBcasa_carneDataSet3.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.DBcasa_carneDataSet3.usuario);
            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
