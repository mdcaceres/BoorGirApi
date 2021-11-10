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
    public partial class FrmConsultarProductos : Form
    {
        Gestor gestor; 
        public FrmConsultarProductos()
        {
            InitializeComponent();
            gestor = new Gestor(new Factory());
        }

        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {
            DataTable table = gestor.productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["id"],table.Rows[i]["nombre"], table.Rows[i]["precio"]);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DataTable table = gestor.productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS_POR_NOMBRE", "@nombre", txtProducto.Text);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["id"], table.Rows[i]["nombre"], table.Rows[i]["precio"]);
            }
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DataTable table = gestor.productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["id"], table.Rows[i]["nombre"], table.Rows[i]["precio"]);
            }
        }

        private void btnSalirConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
