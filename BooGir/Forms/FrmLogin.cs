using BooGir.DATA;
using BooGir.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooGir.Forms
{
    public partial class FrmLogin : Form
    {
        HelperDao helper;

        SqlDataReader dr;

        public int UserId; 
        public FrmLogin()
        {
            InitializeComponent();
            helper = HelperDao.GetHelper();
            //vendedor = new Vendedor(); 
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro nuevo = new FrmRegistro();
            nuevo.ShowDialog();
        }

        //METODOS
        private void login()
        {
            helper.OpenConn();
            helper.SetCommand(CommandType.StoredProcedure, "SP_VERIFICAR_LOGIN");
            helper.command.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            helper.command.Parameters.AddWithValue("@contraseña", txtContrasenia.Text);

            //recibiendo el parametro de salida
            SqlParameter id = new SqlParameter();
            id.ParameterName = "@idVendedor";
            id.SqlDbType = SqlDbType.Int;
            id.Direction = ParameterDirection.Output;
            helper.AddParameters(id);

            helper.command.ExecuteNonQuery();

            UserId = (int)id.Value;

            dr = helper.command.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                frmPrincipal nuevo = new frmPrincipal(UserId); //pasar el usuario
                nuevo.ShowDialog();
                helper.CloseConn();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Sistema");
                helper.CloseConn();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
