using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir.Reports
{
    public partial class FacturacionP : Form
    {
        public FacturacionP()
        {
            InitializeComponent();
        }

        private void FacturacionP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dsreports.PRODUCTOS' table. You can move, or remove it, as needed.
            this.PRODUCTOSTableAdapter.Fill(this.Dsreports.PRODUCTOS);

            this.reportViewer1.RefreshReport();
        }
    }
}
