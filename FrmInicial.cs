﻿using System;
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
    public partial class FrmInicial : MetroFramework.Forms.MetroForm
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProduto prod = new FrmCadProduto();
            prod.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUsuario usu = new FrmCadUsuario();
            usu.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadLogin log = new FrmCadLogin();
            log.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente cli = new FrmCadCliente();
            cli.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor forne = new FrmCadFornecedor();
            forne.Show();
        }

       
    }
}
