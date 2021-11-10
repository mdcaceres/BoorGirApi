using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir.Reports
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //string fecDesde = dtpDesde.Value.ToString();
            //string fecHasta = dtpHasta.Value.ToString();

            SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=db_boorgir;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Facturacion", cnn);
            cmd.Parameters.AddWithValue("@fecha1", dtpDesde.Value);
            //string date = dtpDesde.Value.ToString("dd/MM/yyyy");
            cmd.Parameters.AddWithValue("@fecha2", dtpHasta.Value);

            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", tabla));

        }

        private void btnFactProd_Click(object sender, EventArgs e)
        {
            new FacturacionP().Show(); 
        }

        private void btnFactVend_Click(object sender, EventArgs e)
        {
            new FormVendedores().Show(); 
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dsreports.PRODUCTOS' table. You can move, or remove it, as needed.
           // this.PRODUCTOSTableAdapter.Fill(this.Dsreports.PRODUCTOS);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
        }
    }
}
