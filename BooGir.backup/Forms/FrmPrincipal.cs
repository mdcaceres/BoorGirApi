using BooGir.DATA;
using BooGir.DATA.Factory;
using BooGir.DATA.servicios;
using BooGir.Forms;
using BooGir.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir
{
    public partial class frmPrincipal : Form
    {
        int UserId;
        Gestor gestor; 
        public frmPrincipal(int id)
        {
            InitializeComponent();
            CustomDesign();
            gestor = new Gestor(new Factory());
            UserId = id; 
        }

        private void CustomDesign()
        {
            subMenuFacturas.Visible = false;
            subMenuTransacciones.Visible = false;
            subMenuReportes.Visible = false;
            subMenuArchivo.Visible = false;
            subMenuAcercaDe.Visible = false;
        }

        private void HideSubMenu()
        {
            if (subMenuFacturas.Visible)
                subMenuFacturas.Visible = false;
            if (subMenuTransacciones.Visible)
                subMenuTransacciones.Visible = false;
            if (subMenuReportes.Visible)
                subMenuReportes.Visible = false;
            if (subMenuArchivo.Visible)
                subMenuArchivo.Visible = false;
            if (subMenuAcercaDe.Visible)
                subMenuAcercaDe.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        internal static int maximunSize;

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
            PanelContainer.Controls.Add(childForm);
            //asociamos el form con el panel contenedor
            PanelContainer.Tag = childForm;
            //traemos el form al frente para tapar el logo 
            childForm.BringToFront();
            childForm.Show(); 
        }

        #region Facturas
        private void btnFacturas_Click(object sender, EventArgs e)
        {

            ShowSubMenu(subMenuFacturas);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton
            this.MaximumSize = new Size(997, 851);
            HideSubMenu();
            OpenForm(new FrmNuevaFactura(UserId));
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            this.MaximumSize = new Size(997, 851);
            HideSubMenu();
            OpenForm(new FrmConsultarFacturas());

        }

        #endregion

        #region Transacciones
        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuTransacciones);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            this.MaximumSize = new Size(997, 851);
            HideSubMenu();
            OpenForm(new FrmConsultarClientes(this.PanelContainer));
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            this.MaximumSize = new Size(997, 851);
            HideSubMenu();
            OpenForm(new FrmConsultarProductos());
        }

        #endregion
        
        #region Reportes
        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuReportes);
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            
            this.Size = new Size(1000, 500);
            HideSubMenu();
            //this.Size = new Size(980, 500);
            OpenForm(new FrmReportes());
            
        }
        #endregion

        #region AcercaDe
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuAcercaDe);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            HideSubMenu();
        }
        #endregion

        #region Archivo
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuArchivo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //escondemos los submenus despues de darle click a un boton 
            HideSubMenu();
            this.Dispose();
        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblId.Text = $"{ UserId}";
            lblNombre.Text = gestor.VendedorDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_VENDEDORES_POR_ID", "@id", UserId).Rows[0]["nombre"].ToString();
   
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
