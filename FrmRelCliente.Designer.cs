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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelCliente));
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
            this.RelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClienteBindingSource;
            this.RelCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.RelCliente.LocalReport.ReportEmbeddedResource = "MASYEV1.RelCliente.rdlc";
            this.RelCliente.Location = new System.Drawing.Point(12, 63);
            this.RelCliente.Name = "RelCliente";
            this.RelCliente.ServerReport.BearerToken = null;
            this.RelCliente.Size = new System.Drawing.Size(764, 252);
            this.RelCliente.TabIndex = 0;
            // 
            // ClienteTableAdapter
            // 
            this.ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(665, 321);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 29);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 352);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.RelCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelCliente";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "FrmRelCliente";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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