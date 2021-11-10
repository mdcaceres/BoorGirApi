using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir.Reportes
{
    public partial class FacturacionV : Form
    {
        public FacturacionV()
        {
            InitializeComponent();
        }

        private void FacturacionV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSReportes.VENDEDORES' Puede moverla o quitarla según sea necesario.
            this.VENDEDORESTableAdapter.Fill(this.DSReportes.VENDEDORES);

            this.reportViewer1.RefreshReport();
        }
    }
}
