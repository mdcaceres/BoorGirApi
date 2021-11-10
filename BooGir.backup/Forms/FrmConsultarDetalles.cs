using BooGir.DATA.Factory;
using BooGir.DATA.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir.Forms
{
    public partial class FrmConsultarDetalles : Form
    {
        Gestor gestor;
        int factura;
        public FrmConsultarDetalles(int factura)
        {
            InitializeComponent();
            gestor = new Gestor(new Factory());
            this.factura = factura;
        }

        private void FrmConsultarDetalles_Load(object sender, EventArgs e)
        {
            DataTable table = gestor.facturasDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_DETALLES_POR_ID", "@id_factura" ,factura);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvDetalles.Rows.Add(table.Rows[i]["cantidad"], table.Rows[i]["nombre"], table.Rows[i]["precio"]);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
