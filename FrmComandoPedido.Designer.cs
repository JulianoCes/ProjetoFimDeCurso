namespace MASYEV1
{
    partial class FrmComandoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComandoPedido));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.DBcasa_carneDataSet2 = new MASYEV1.DBcasa_carneDataSet2();
            this.PedidoDeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PedidoDeliveryTableAdapter = new MASYEV1.DBcasa_carneDataSet2TableAdapters.PedidoDeliveryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoDeliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PedidoDeliveryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MASYEV1.RelComandoPedido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 249);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(23, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(101, 15);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(616, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(540, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(70, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID Pedido";
            // 
            // DBcasa_carneDataSet2
            // 
            this.DBcasa_carneDataSet2.DataSetName = "DBcasa_carneDataSet2";
            this.DBcasa_carneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PedidoDeliveryBindingSource
            // 
            this.PedidoDeliveryBindingSource.DataMember = "PedidoDelivery";
            this.PedidoDeliveryBindingSource.DataSource = this.DBcasa_carneDataSet2;
            // 
            // PedidoDeliveryTableAdapter
            // 
            this.PedidoDeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // FrmComandoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmComandoPedido";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Comando Pedido";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmComandoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoDeliveryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.BindingSource PedidoDeliveryBindingSource;
        private DBcasa_carneDataSet2 DBcasa_carneDataSet2;
        private DBcasa_carneDataSet2TableAdapters.PedidoDeliveryTableAdapter PedidoDeliveryTableAdapter;
    }
}