using BooGir.DATA;
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
    public partial class FrmConsultarFacturas : Form
    {
        Gestor gestor;
        public FrmConsultarFacturas()
        {
            InitializeComponent();
            gestor = new Gestor(new Factory());
        }

        private void btnSalirConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarFacturas_Load(object sender, EventArgs e)
        {
            DataTable table = gestor.facturasDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_FACTURAS");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["nro_factura"], table.Rows[i]["cliente"], table.Rows[i]["fecha"], table.Rows[i]["total"]);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DataTable table = gestor.facturasDao.ReturnTable(CommandType.StoredProcedure, "SP_FACTURA_POR_FECHA","@fechaDesde",dtpFechaDesde.Value.ToString(),"@fechaHasta",dtpFechaHasta.Value.ToString());
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["nro_factura"], table.Rows[i]["cliente"], table.Rows[i]["fecha"], table.Rows[i]["total"]);
            }
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DataTable table = gestor.facturasDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_FACTURAS");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["nro_factura"], table.Rows[i]["cliente"], table.Rows[i]["fecha"], table.Rows[i]["total"]);
            }
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroFactura = int.Parse(dgvConsultar.CurrentRow.Cells[0].Value.ToString());

            if (dgvConsultar.CurrentCell.ColumnIndex == 4)
            {
                //boton editar abre otro form
                new FrmConsultarDetalles(nroFactura).ShowDialog();

                //como hago para setear el form?
            }
        }
    }
}