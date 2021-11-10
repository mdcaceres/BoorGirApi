using BooGir.DATA.Factory;
using BooGir.DATA.servicios;
using BooGir.Entidades;
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
    public partial class FrmModificarCliente : Form
    {
        Clientes cliente;
        Gestor gestor;
        int dni; 
        public FrmModificarCliente(int dni)
        {
            InitializeComponent();
            cliente = new Clientes();
            cliente.Dni = dni;
            this.dni = dni; 
            txtDni.Text = dni.ToString();
            txtDni.Enabled = false;
            gestor = new Gestor(new Factory());
        }

        public void BringData(int dni)
        {
            DataTable table = gestor.clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES_POR_DNI2", "@DNI", dni);
            txtApellido.Text = table.Rows[0]["apellido"].ToString();
            txtNombre.Text = table.Rows[0]["nombre"].ToString();
            txtTelefono.Text = table.Rows[0]["telefono"].ToString();
            txtDireccion.Text = table.Rows[0]["direccion"].ToString();
            cboBarrio.SelectedItem = table.Rows[0]["barrio"].ToString();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            BringData(dni); 
        }
    }
}
