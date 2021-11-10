
namespace BooGir.Reports
{
    partial class FrmReportes
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
            System.Windows.Forms.Button btnVolver;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Dsreports = new BooGir.Reports.Dsreports();
            this.btnFactVend = new System.Windows.Forms.Button();
            this.btnFactProd = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dsreports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVolver.Location = new System.Drawing.Point(67, 627);
            btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(135, 35);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Dsreports
            // 
            this.Dsreports.DataSetName = "Dsreports";
            this.Dsreports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFactVend
            // 
            this.btnFactVend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnFactVend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactVend.Location = new System.Drawing.Point(742, 41);
            this.btnFactVend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFactVend.Name = "btnFactVend";
            this.btnFactVend.Size = new System.Drawing.Size(276, 37);
            this.btnFactVend.TabIndex = 20;
            this.btnFactVend.Text = "Facturacion Vendedores";
            this.btnFactVend.UseVisualStyleBackColor = false;
            this.btnFactVend.Click += new System.EventHandler(this.btnFactVend_Click);
            // 
            // btnFactProd
            // 
            this.btnFactProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnFactProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactProd.Location = new System.Drawing.Point(742, 98);
            this.btnFactProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFactProd.Name = "btnFactProd";
            this.btnFactProd.Size = new System.Drawing.Size(276, 35);
            this.btnFactProd.TabIndex = 21;
            this.btnFactProd.Text = "Facturacion Productos";
            this.btnFactProd.UseVisualStyleBackColor = false;
            this.btnFactProd.Click += new System.EventHandler(this.btnFactProd_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(556, 98);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(135, 35);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(213, 103);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(298, 26);
            this.dtpHasta.TabIndex = 18;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(213, 47);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(298, 26);
            this.dtpDesde.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha Desde";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.FacturacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BooGir.Reports.Facturacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 188);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1070, 363);
            this.reportViewer1.TabIndex = 22;
            // 
            // FacturacionBindingSource
            // 
            this.FacturacionBindingSource.DataMember = "Facturacion";
            this.FacturacionBindingSource.DataSource = this.Dsreports;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 693);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnFactVend);
            this.Controls.Add(this.btnFactProd);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnVolver);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dsreports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactVend;
        private System.Windows.Forms.Button btnFactProd;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Dsreports Dsreports;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturacionBindingSource;
    }
}