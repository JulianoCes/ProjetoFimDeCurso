namespace MASYEV1
{
    partial class FrmRelCaixa
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelCaixa));
            this.ProdutosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBcasa_carneDataSet4 = new MASYEV1.DBcasa_carneDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.relVenda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutosVendidosTableAdapter = new MASYEV1.DBcasa_carneDataSet4TableAdapters.ProdutosVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosVendidosBindingSource
            // 
            this.ProdutosVendidosBindingSource.DataMember = "ProdutosVendidos";
            this.ProdutosVendidosBindingSource.DataSource = this.DBcasa_carneDataSet4;
            // 
            // DBcasa_carneDataSet4
            // 
            this.DBcasa_carneDataSet4.DataSetName = "DBcasa_carneDataSet4";
            this.DBcasa_carneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // relVenda
            // 
            this.relVenda.BackColor = System.Drawing.Color.Black;
            this.relVenda.ForeColor = System.Drawing.Color.White;
            reportDataSource1.Name = "relVenda";
            reportDataSource1.Value = this.ProdutosVendidosBindingSource;
            this.relVenda.LocalReport.DataSources.Add(reportDataSource1);
            this.relVenda.LocalReport.ReportEmbeddedResource = "MASYEV1.RelVenda.rdlc";
            this.relVenda.Location = new System.Drawing.Point(23, 63);
            this.relVenda.Name = "relVenda";
            this.relVenda.ServerReport.BearerToken = null;
            this.relVenda.Size = new System.Drawing.Size(641, 244);
            this.relVenda.TabIndex = 2;
            // 
            // ProdutosVendidosTableAdapter
            // 
            this.ProdutosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 341);
            this.Controls.Add(this.relVenda);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelCaixa";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Relatório de Caixa";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmRelCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer relVenda;
        private System.Windows.Forms.BindingSource ProdutosVendidosBindingSource;
        private DBcasa_carneDataSet4 DBcasa_carneDataSet4;
        private DBcasa_carneDataSet4TableAdapters.ProdutosVendidosTableAdapter ProdutosVendidosTableAdapter;
    }
}