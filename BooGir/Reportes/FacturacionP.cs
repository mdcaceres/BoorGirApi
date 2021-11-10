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
    public partial class FacturacionP : Form
    {
        public FacturacionP()
        {
            InitializeComponent();
        }

        private void FacturacionP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSReportes.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.PRODUCTOSTableAdapter.Fill(this.DSReportes.PRODUCTOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
