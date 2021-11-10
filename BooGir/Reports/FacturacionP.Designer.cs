
namespace BooGir.Reports
{
    partial class FacturacionP
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
            this.PRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dsreports = new BooGir.Reports.Dsreports();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRODUCTOSTableAdapter = new BooGir.Reports.DsreportsTableAdapters.PRODUCTOSTableAdapter();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dsreports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PRODUCTOSBindingSource
            // 
            this.PRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.PRODUCTOSBindingSource.DataSource = this.Dsreports;
            // 
            // Dsreports
            // 
            this.Dsreports.DataSetName = "Dsreports";
            this.Dsreports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pRODUCTOSBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BooGir.Reports.FacturacionProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(761, 433);
            this.reportViewer1.TabIndex = 0;
            // 
            // PRODUCTOSTableAdapter
            // 
            this.PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.Dsreports;
            // 
            // FacturacionP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FacturacionP";
            this.Text = "FacturacionP";
            this.Load += new System.EventHandler(this.FacturacionP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dsreports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUCTOSBindingSource;
        private Dsreports Dsreports;
        private DsreportsTableAdapters.PRODUCTOSTableAdapter PRODUCTOSTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
    }
}