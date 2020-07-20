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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.DBcasa_carneDataSet2 = new MASYEV1.DBcasa_carneDataSet2();
            this.CaixaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CaixaVendaTableAdapter = new MASYEV1.DBcasa_carneDataSet2TableAdapters.CaixaVendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaixaVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.WindowText;
            this.reportViewer1.ForeColor = System.Drawing.Color.White;
            reportDataSource2.Name = "RelCaixa";
            reportDataSource2.Value = this.CaixaVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MASYEV1.RelCaixa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(656, 244);
            this.reportViewer1.TabIndex = 0;
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
            // DBcasa_carneDataSet2
            // 
            this.DBcasa_carneDataSet2.DataSetName = "DBcasa_carneDataSet2";
            this.DBcasa_carneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CaixaVendaBindingSource
            // 
            this.CaixaVendaBindingSource.DataMember = "CaixaVenda";
            this.CaixaVendaBindingSource.DataSource = this.DBcasa_carneDataSet2;
            // 
            // CaixaVendaTableAdapter
            // 
            this.CaixaVendaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelCaixa";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Relatório de Caixa";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FrmRelCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBcasa_carneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaixaVendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource CaixaVendaBindingSource;
        private DBcasa_carneDataSet2 DBcasa_carneDataSet2;
        private DBcasa_carneDataSet2TableAdapters.CaixaVendaTableAdapter CaixaVendaTableAdapter;
    }
}