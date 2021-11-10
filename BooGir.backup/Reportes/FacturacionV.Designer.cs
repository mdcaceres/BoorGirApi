
namespace BooGir.Reportes
{
    partial class FacturacionV
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSReportes = new BooGir.Reportes.DSReportes();
            this.VENDEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VENDEDORESTableAdapter = new BooGir.Reportes.DSReportesTableAdapters.VENDEDORESTableAdapter();
            this.vENDEDORESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vENDEDORESBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BooGir.Reportes.FacturacionVendedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(658, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VENDEDORESBindingSource
            // 
            this.VENDEDORESBindingSource.DataMember = "VENDEDORES";
            this.VENDEDORESBindingSource.DataSource = this.DSReportes;
            // 
            // VENDEDORESTableAdapter
            // 
            this.VENDEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // vENDEDORESBindingSource1
            // 
            this.vENDEDORESBindingSource1.DataMember = "VENDEDORES";
            this.vENDEDORESBindingSource1.DataSource = this.DSReportes;
            // 
            // FacturacionV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(658, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FacturacionV";
            this.Text = "FacturacionV";
            this.Load += new System.EventHandler(this.FacturacionV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VENDEDORESBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.VENDEDORESTableAdapter VENDEDORESTableAdapter;
        private System.Windows.Forms.BindingSource vENDEDORESBindingSource1;
    }
}