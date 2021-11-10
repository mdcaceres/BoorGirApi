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
    public partial class FrmNuevaFactura : Form
    {
        Gestor gestor;
        Factura Nueva;
        double descuento;
        int UserId;
        enum mode { Read, Create };
        int flag; 


        public FrmNuevaFactura(int UserId)
        {
            InitializeComponent();
            gestor = new Gestor(new Factory());
            Nueva = new Factura();
            this.UserId = UserId;
            flag = ((int)mode.Read); 
            
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            lblNroPresupuesto.Text += gestor.facturasDao.GetNext().ToString();
            gestor.loadCombo(cboBarrio, CommandType.StoredProcedure, "SP_CONSULTAR_BARRIOS", "descripcion", "id_barrio");
            gestor.loadCombo(cboProducto, CommandType.StoredProcedure, "sp_productos", "nom_producto", "id_producto");
            gestor.loadCombo(cboForma, CommandType.StoredProcedure, "SP_CONSULTAR_FORMAS_PAGO", "descripcion", "id_forma");
            lblFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            txtDescuento.Text = "0";
        }

        private bool validateProducto()
        {
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["ColProd"].Value.ToString().Equals(cboProducto.Text))
                {
                    MessageBox.Show("Este producto ya se encuentra agregado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            if (nudCantidad.Text.Equals("0"))
            {
                MessageBox.Show("Debe elegir una cantidad", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboProducto.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;


        }

        private bool ValidateCliente()
        {
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Porfavor indique el dni", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Porfavor llene el nombre del cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Porfavor complete el apellido del cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboBarrio.Text == string.Empty)
            {
                MessageBox.Show("Porfavor seleccione un barrio", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void SaveFactura()
        {
            Nueva.IdVendedor = UserId;
            Nueva.DNI = Convert.ToInt32(txtDni.Text);
            Nueva.FormaPago = Convert.ToInt32(cboForma.SelectedValue);
            Nueva.Descuento = double.Parse(txtDescuento.Text);
            Nueva.total = Nueva.CalcularTotal() - descuento;
            if (gestor.ConfirmObject(Nueva))
            {
                MessageBox.Show("La factura se grabo correctamente", "control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("La factura no se pudo grabar", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        public bool search(DataTable table, string dni)
        {
            foreach (DataRow row in table.Rows)
            {
                if (txtDni.Text.Equals(row[0].ToString()))
                {
                    return true; 
                }
            }
            return false; 
        }

        public void ActTxt()
        {
            // metodo para activiar txt
        }

        public void CleanTxt()
        {
            //LIMPIAR TXT
        }

        private void btnDni_Click(object sender, EventArgs e)
        {
            DataTable allClients = gestor.clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES");
            if (search(allClients, txtDni.Text))
            {
                //TRAER DATOS DE LA TABLA A LOS TXT 


                DataTable client = gestor.clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES_POR_DNI2", "@DNI", Convert.ToInt32(txtDni.Text));
                txtNombre.Text = client.Rows[0]["nombre"].ToString();
                txtApellido.Text = client.Rows[0]["apellido"].ToString();
                txtTelefono.Text = client.Rows[0]["telefono"].ToString();
                txtDireccion.Text = client.Rows[0]["direccion"].ToString();
                cboBarrio.SelectedIndex = Convert.ToInt32(client.Rows[0]["barrio"]);
            }
            else
            {
                MessageBox.Show("Ingrese los datos del cliente", "control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flag = ((int)mode.Create);

                //hacer metodos !!! OJO
                txtApellido.BackColor = Color.White;
                txtNombre.BackColor = Color.White;
                txtTelefono.BackColor = Color.White;
                txtDireccion.BackColor = Color.White;
                cboBarrio.BackColor = Color.White;


                txtApellido.Enabled = true;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
                cboBarrio.Enabled = true;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (validateProducto())
            {
                //creamos un DataRowView
                //cada fila va a ser un item de mi grilla
                //lo debemos castear
                //el iten seleccionado el en combo lo voy a comvertir en una fila de la grilla
                DataRowView item = (DataRowView)cboProducto.SelectedItem;
                //creo unas variables para almacenar los datos del producto o item seleccionado
                int prod = Convert.ToInt32(item.Row.ItemArray[0]);
                string nom = item.Row.ItemArray[1].ToString();
                double pre = Convert.ToDouble(item.Row.ItemArray[2]);
                int cant = Convert.ToInt32(nudCantidad.Text);

                Producto p = new Producto(prod, nom, pre);
                DetalleFactura detalle = new DetalleFactura(p, cant);

                Nueva.AgregarDetalle(detalle);

                dgvDetalles.Rows.Add(new object[] { prod, nom, pre, cant });

                lblSubtotal.Text = "Sub Total $ " + Nueva.CalcularTotal().ToString();
                descuento = Nueva.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;
                lblDescuento2.Text = "Descuento $ " + descuento.ToString();
                lblTotal.Text = "Total $ " + (Nueva.CalcularTotal() - descuento).ToString();
            }

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                Nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                lblSubtotal.Text = "Sub Total $ " + Nueva.CalcularTotal().ToString();
                descuento = Nueva.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;
                lblDescuento2.Text = "Descuento $ " + descuento.ToString();
                lblTotal.Text = "Total $ " + (Nueva.CalcularTotal() - descuento).ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateCliente())
            {
                Clientes cliente = new Clientes(int.Parse(txtDni.Text), Convert.ToInt32(txtTelefono.Text), txtNombre.Text, txtApellido.Text, int.Parse(cboBarrio.SelectedValue.ToString()), txtDireccion.Text);
                if (flag == ((int)mode.Create))
                    gestor.clientesDao.Create(cliente);
                SaveFactura();
            }
        }

    }
}
