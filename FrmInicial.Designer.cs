namespace MASYEV1
{
    partial class FrmInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.MstInicial = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImagemInicial = new System.Windows.Forms.PictureBox();
            this.MstInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // MstInicial
            // 
            this.MstInicial.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.MstInicial.BackColor = System.Drawing.Color.Brown;
            this.MstInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MstInicial.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MstInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.MstInicial.Location = new System.Drawing.Point(27, 69);
            this.MstInicial.Name = "MstInicial";
            this.MstInicial.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MstInicial.Size = new System.Drawing.Size(869, 38);
            this.MstInicial.TabIndex = 5;
            this.MstInicial.Text = "MstInicial";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.cartãoDeVendaToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // cartãoDeVendaToolStripMenuItem
            // 
            this.cartãoDeVendaToolStripMenuItem.Name = "cartãoDeVendaToolStripMenuItem";
            this.cartãoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.cartãoDeVendaToolStripMenuItem.Text = "Login";
            this.cartãoDeVendaToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaVendaToolStripMenuItem,
            this.caixaCompraToolStripMenuItem,
            this.pedidoDeliveryToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // caixaVendaToolStripMenuItem
            // 
            this.caixaVendaToolStripMenuItem.Name = "caixaVendaToolStripMenuItem";
            this.caixaVendaToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.caixaVendaToolStripMenuItem.Text = "Caixa Venda";
            this.caixaVendaToolStripMenuItem.Click += new System.EventHandler(this.caixaVendaToolStripMenuItem_Click);
            // 
            // caixaCompraToolStripMenuItem
            // 
            this.caixaCompraToolStripMenuItem.Name = "caixaCompraToolStripMenuItem";
            this.caixaCompraToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.caixaCompraToolStripMenuItem.Text = "Caixa Compra";
            this.caixaCompraToolStripMenuItem.Click += new System.EventHandler(this.caixaCompraToolStripMenuItem_Click);
            // 
            // pedidoDeliveryToolStripMenuItem
            // 
            this.pedidoDeliveryToolStripMenuItem.Name = "pedidoDeliveryToolStripMenuItem";
            this.pedidoDeliveryToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.pedidoDeliveryToolStripMenuItem.Text = "Pedido Delivery";
            this.pedidoDeliveryToolStripMenuItem.Click += new System.EventHandler(this.pedidoDeliveryToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.produtosToolStripMenuItem1,
            this.usuárioToolStripMenuItem,
            this.caixaToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(188, 34);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(188, 34);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem1
            // 
            this.caixaToolStripMenuItem1.Name = "caixaToolStripMenuItem1";
            this.caixaToolStripMenuItem1.Size = new System.Drawing.Size(188, 34);
            this.caixaToolStripMenuItem1.Text = "Caixa";
            this.caixaToolStripMenuItem1.Click += new System.EventHandler(this.caixaToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(70, 34);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbImagemInicial
            // 
            this.pbImagemInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemInicial.ErrorImage = null;
            this.pbImagemInicial.Image = global::MASYEV1.Properties.Resources.pagina_incial;
            this.pbImagemInicial.Location = new System.Drawing.Point(27, 110);
            this.pbImagemInicial.Name = "pbImagemInicial";
            this.pbImagemInicial.Size = new System.Drawing.Size(869, 217);
            this.pbImagemInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemInicial.TabIndex = 6;
            this.pbImagemInicial.TabStop = false;
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MASYEV1.Properties.Resources.pagina_incial;
            this.ClientSize = new System.Drawing.Size(923, 356);
            this.Controls.Add(this.pbImagemInicial);
            this.Controls.Add(this.MstInicial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FrmInicial";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Menu Inicial";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MstInicial.ResumeLayout(false);
            this.MstInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MstInicial;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeliveryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbImagemInicial;
    }
}