
using LibraryBoorGir.DATA.Factory;
using LibraryBoorGir.Entidades;
using LibraryBoorGir.Interfaces;
using LibraryBoorGir.servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryBoorGir.DATA.servicios
{
    public class Aplicacion : IAplicacion
    {
        public IDaoVendedores LoginDao { get; set; }

        public IDaoVendedores VendedorDao { get; set; }

        public IDaoFacturas facturasDao { get; set; }

        public IDaoCliente clientesDao { get; set; }

        public IDao productosDao { get; set; }

        public IDao pagosDao { get; set; }

        public IDao barriosDao { get; set; }

        public Aplicacion(AbstractFactory factory)
        {
            LoginDao = factory.CreateLoginDao();
            VendedorDao = factory.CreateVendedorDao();
            facturasDao = factory.CreateFacturasDao();
            productosDao = factory.CreateProductosDao();
            clientesDao = factory.CreateClientesDao();
            pagosDao = factory.CreatePagos();
            barriosDao = factory.CreateBarrios(); 
        }

        public bool Create(Vendedor vendedor)
        {
            return LoginDao.Create(vendedor);
        }

        public int BringFactura()
        {
            return facturasDao.GetNext(); 
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

        public bool ConfirmObject(Factura myObject)
        {
            return facturasDao.Create(myObject);
        }

        public List<Clientes> ConsultarClientes()
        {
            List<Clientes> lst = new List<Clientes>(); 
            DataTable table = clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES2");

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Clientes cliente = new Clientes();
                cliente.Nombre = row["nombre"].ToString();
                cliente.Dni = Convert.ToInt32(row["DNI"]);
                cliente.Apellido = row["apellido"].ToString();
                cliente.Direccion = row["direccion"].ToString();
                cliente.IdBarrio = Convert.ToInt32(row["barrio"]);
                cliente.Telefono = Convert.ToInt32(row["telefono"]); 

                lst.Add(cliente);
            }
            return lst;
        }

        public List<Clientes> ConsultarClientes(int dni)
        {
            List<Clientes> lst = new List<Clientes>();
            DataTable table = clientesDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_CLIENTES_POR_DNI2", "@DNI", dni);

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Clientes cliente = new Clientes();
                cliente.Nombre = row["nombre"].ToString();
                cliente.Dni = Convert.ToInt32(row["DNI"]);
                cliente.Apellido = row["apellido"].ToString();
                cliente.Direccion = row["direccion"].ToString();
                cliente.IdBarrio = Convert.ToInt32(row["barrio"]);
                cliente.Telefono = Convert.ToInt32(row["telefono"]);

                lst.Add(cliente);
            }
            return lst;
        }

        public bool CrearFactura(Factura factura)
        {
            return facturasDao.Create(factura);
        }



        public List<DetalleFactura> ConsultarDetalles()
        {
            throw new NotImplementedException();
        }

        public List<Producto> TraerProductos()
        {
            List<Producto> lst = new List<Producto>();
            DataTable table = productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS");

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Producto producto = new Producto(Convert.ToInt32(row["id"]), row["nombre"].ToString(), Convert.ToDouble(row["precio"]));
                

                lst.Add(producto);
            }
            return lst;
        }

        public List<Producto> TraerProductos(string value)
        {
            List<Producto> lst = new List<Producto>();
            DataTable table = productosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_PRODUCTOS_POR_NOMBRE", "@nombre", value);

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Producto producto = new Producto(Convert.ToInt32(row["id"]), row["nombre"].ToString(), Convert.ToDouble(row["precio"]));


                lst.Add(producto);
            }
            return lst;
        }

        public List<Pagos> TraerPagos()
        {
            List<Pagos> lst = new List<Pagos>();
            DataTable table = pagosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_FORMAS_PAGO");

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Pagos pago = new Pagos(Convert.ToInt32(row["id_forma"]), row["descripcion"].ToString());
                string descr = pago.Descripcion; 

                lst.Add(pago);
            }
            return lst;
        }

        public List<Pagos> TraerBarrios()
        {
            List<Pagos> lst = new List<Pagos>();
            DataTable table = pagosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_FORMAS_PAGO");

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Pagos pago = new Pagos(Convert.ToInt32(row["id_forma"]), row["descripcion"].ToString());

                lst.Add(pago);
            }
            return lst;
        }

        List<Barrios> IAplicacion.TraerBarrios()
        {
            List<Barrios> lst = new List<Barrios>();
            DataTable table = barriosDao.ReturnTable(CommandType.StoredProcedure, "SP_CONSULTAR_BARRIOS");

            foreach (DataRow row in table.Rows)
            {
                //Por cada registro creamos un objeto del dominio
                Barrios barrio = new Barrios(Convert.ToInt32(row["id_barrio"]), row["descripcion"].ToString());
                
                lst.Add(barrio);
            }
            return lst;
        }

        public void CrearCliente(Clientes cliente)
        {
            clientesDao.Create(cliente);
        }
    }
}
