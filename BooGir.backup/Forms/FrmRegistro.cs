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
    public partial class FrmRegistro : Form
    {
        Vendedor vendedor;
        Gestor gestor; 
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            vendedor = new Vendedor();
            gestor = new Gestor(new Factory()); 
        }

        private void ConfirmUser()
        {
            vendedor.nom_vendedor = txtBoxUsuario.Text;
            vendedor.ape_vendedor = txtBoxApellido.Text;
            vendedor.usuario = txtBoxUsers.Text;
            vendedor.password = txtBoxPasss.Text;

            if (gestor.Create(vendedor))
            {
                MessageBox.Show($"Usuario {vendedor.nom_vendedor} creado correctamente ", "control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo crear el usuario", "control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ConfirmUser(); 
        }
    }
}
