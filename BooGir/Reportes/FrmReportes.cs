using BooGir.DATA.servicios;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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

namespace BooGir.Reportes
{
    public partial class FrmReportes : Form
    {
        
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSReportes.VENDEDORES' Puede moverla o quitarla según sea necesario.
            //this.VENDEDORESTableAdapter.Fill(this.DSReportes.VENDEDORES);
            // TODO: esta línea de código carga datos en la tabla 'dSReportes.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            // this.pRODUCTOSTableAdapter.Fill(this.dSReportes.PRODUCTOS);




            // TODO: esta línea de código carga datos en la tabla 'DSReportes.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            //this.PRODUCTOSTableAdapter.Fill(this.DSReportes.PRODUCTOS);

            this.rvReportes.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //string fecDesde = dtpDesde.Value.ToString();
            //string fecHasta = dtpHasta.Value.ToString();

            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-VO7TE51;Initial Catalog=db_boorgir;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("FACTURACION", cnn);
            cmd.Parameters.AddWithValue("@fecha1", dtpDesde.Value);
            cmd.Parameters.AddWithValue("@fecha2", dtpHasta.Value);

            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            rvReportes.LocalReport.DataSources.Clear();
            rvReportes.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tabla));


            
        }

      
        private void btnFactVend_Click(object sender, EventArgs e)
        {
            new FacturacionV().Show();
        }

        private void btnFactProd_Click(object sender, EventArgs e)
        {
            new FacturacionP().Show();
        }
    }
}
