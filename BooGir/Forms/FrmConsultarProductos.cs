using BooGir.DATA.Factory;
using BooGir.DATA.servicios;
using LibraryBoorGir.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir.Forms
{
    public partial class FrmConsultarProductos : Form
    {
        Gestor gestor;
        public string filtro; 
        public FrmConsultarProductos()
        {
            InitializeComponent();
            gestor = new Gestor(new Factory());
        }

        public async void CargarProductosAsync()
        {
            string url = "https://localhost:44373/Productos";
            //creamos el httpclient que atravez de este objeto es que se consume la api
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(content);
                foreach(Producto p in lst)
                {
                    dgvConsultar.Rows.Add(p.idProducto, p.nomProducto, p.preUnitario);
                }
            }
        }

        public async void FiltrarProductosAsync()
        {
            string url = "https://localhost:44373/Productos2?nombre=" + txtProducto.Text;
            //creamos el httpclient que atravez de este objeto es que se consume la api
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(content);
                foreach (Producto p in lst)
                {
                    dgvConsultar.Rows.Add(p.idProducto, p.nomProducto, p.preUnitario);
                }
            }
        }

        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {
            //DataTable table = gestor.productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS");
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    dgvConsultar.Rows.Add(table.Rows[i]["id"],table.Rows[i]["nombre"], table.Rows[i]["precio"]);
            //}
            CargarProductosAsync();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            dgvConsultar.Rows.Clear();
            //DataTable table = gestor.productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS_POR_NOMBRE", "@nombre", txtProducto.Text);
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    dgvConsultar.Rows.Add(table.Rows[i]["id"], table.Rows[i]["nombre"], table.Rows[i]["precio"]);
            //}
            FiltrarProductosAsync(); 
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
