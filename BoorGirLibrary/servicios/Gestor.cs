using System;
using System.Data;
using System.Windows.Forms;

namespace BoorGirLibrary
{
    class Gestor 
    {
        public IDaoVendedores LoginDao { get; set; }

        public IDaoVendedores VendedorDao { get; set; }

        public IDaoFacturas facturasDao { get; set; }

        public IDaoCliente clientesDao { get; set; }

        public IDao productosDao { get; set; }

        public Gestor(AbstractFactory factory)
        {
            LoginDao = factory.CreateLoginDao();
            VendedorDao = factory.CreateVendedorDao();
            facturasDao = factory.CreateFacturasDao();
            productosDao = factory.CreateProductosDao();
            clientesDao = factory.CreateClientesDao();
        }
        public bool Create(Vendedor vendedor)
        {
            return LoginDao.Create(vendedor);
        }

        public void Create(Clientes cliente)
        {
            clientesDao.Create(cliente);
        }


        public int BringFactura()
        {
            return facturasDao.GetNext(); 
        }

        public void loadCombo(ComboBox combo, CommandType type, string CommandText, string display, string value)
        {
            DataTable table = facturasDao.ReturnTable(type, CommandText);
            combo.DataSource = table;
            combo.ValueMember = value;
            combo.DisplayMember = display;
            
        }

        public void UserData(CommandType type, string CommandText)
        {
            DataTable table = VendedorDao.ReturnTable(type, CommandText);

            //List<string> dataList = new List<string>(); 
            //for(int i = 0; i < table.Rows.Count;  i++)
            //{
            //    dataList.Add(table.Rows[i]["nombre"].ToString()); 
            //} 
        }

        public void read()
        {
            throw new NotImplementedException();
        }

        public bool Verify()
        {
            throw new NotImplementedException();
        }

        public bool ConfirmObject(Factura myObject)
        {
            return facturasDao.Create(myObject);
        }
    }
}
