namespace MASYEV1
{
    partial class FrmRelCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBcasa_carneDataSet1 = new MASYEV1.DBcasa_carneDataSet1();
            this.RelCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClienteTableAdapter = new MASYEV1.DBcasa_carneDataSet1TableAdapters.ClienteTableAdapter();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.DBcasa_carneDataSet1;
            // 
            // DBcasa_carneDataSet1
            // 
            this.DBcasa_carneDataSet1.DataSetName = "DBcasa_carneDataSet1";
            this.DBcasa_carneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelCliente
            // 
            this.RelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ClienteBindingSource;
            this.RelCliente.LocalReport.DataSources.Add(reportDataSource2);
            this.RelCliente.LocalReport.ReportEmbeddedResource = "MASYEV1.Report1.rdlc";
            this.RelCliente.Location = new System.Drawing.Point(12, 63);
            this.RelCliente.Name = "RelCliente";
            this.RelCliente.ServerReport.BearerToken = null;
            this.RelCliente.Size = new System.Drawing.Size(760, 242);
            this.RelCliente.TabIndex = 0;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(650, 311);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 342);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.RelCliente);
            this.Name = "FrmRelCliente";
            this.Text = "FrmRelCliente";
            this.Load += new System.EventHandler(this.FrmRelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RelCliente;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DBcasa_carneDataSet1 DBcasa_carneDataSet1;
        private DBcasa_carneDataSet1TableAdapters.ClienteTableAdapter ClienteTableAdapter;
        private System.Windows.Forms.Button btnSair;
    }
}