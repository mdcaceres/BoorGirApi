using BooGir.DATA.Factory;
using BooGir.DATA.servicios;
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
using LibraryBoorGir.Entidades; 

namespace BooGir.Forms
{
    public partial class FrmConsultarClientes : Form
    {
        Gestor gestor;
        enum mode { Read, Create, Update };
        int flag;
        private Form activeForm = null;
        Panel panel; 

        public FrmConsultarClientes(Panel panel)
        {
            InitializeComponent();
            gestor = new Gestor(new Factory());
            flag = ((int)mode.Read);
            this.panel = panel; 
        }
        private async void CargarDataGridAsync()
        {
            string url = "https://localhost:44373/Clientes";
            //creamos el httpclient que atravez de este objeto es que se consume la api
            HttpClient cliente = new HttpClient();
            var result = await cliente.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            List<Clientes> lst = JsonConvert.DeserializeObject<List<Clientes>>(content); 
        }
        private async void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            //DataTable table = gestor.clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES");
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    dgvConsultar.Rows.Add(table.Rows[i]["DNI"],table.Rows[i]["cliente"], table.Rows[i]["telefono"], table.Rows[i]["direccion"]);
            //}
            await CargarDataGridAsync(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            //asignamos que el form hijo no esta a nivel supérior
            childForm.TopLevel = false;
            //quitamos los bordes
            childForm.FormBorderStyle = FormBorderStyle.None;
            //le ponemos el dock para que rellene todo el panel 
            childForm.Dock = DockStyle.Fill;
            //agregamos el form a la lista de controles del panel contenedor
            panel.Controls.Clear(); 
            panel.Controls.Add(childForm);
            //asociamos el form con el panel contenedor
            panel.Tag = childForm;
            //traemos el form al frente para tapar el logo 
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            DataTable table = gestor.clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES_POR_DNI", "@dni", Convert.ToInt32(txtDni.Text));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["cliente"], table.Rows[i]["telefono"], table.Rows[i]["direccion"]);
            }
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            dgvConsultar.Rows.Clear();
            txtDni.Clear();
            DataTable table = gestor.clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dgvConsultar.Rows.Add(table.Rows[i]["cliente"], table.Rows[i]["telefono"], table.Rows[i]["direccion"]);
            }
        }

        private void btnSalirConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultar.CurrentCell.ColumnIndex == 3)
            {
                int dni = Convert.ToInt32(dgvConsultar.CurrentRow.Cells[0].Value); 
                flag = ((int)mode.Update);
                //new FrmConsultarDetalles(1).ShowDialog();
                //new FrmModificarCliente().ShowDialog(); 
                OpenForm(new FrmModificarCliente(dni));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            flag = ((int)mode.Create);
        }
    }
}
