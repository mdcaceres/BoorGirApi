using LibraryBoorGir.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.servicios
{
    public interface IAplicacion
    {
        //Consultar clientes 
        public List<DetalleFactura> ConsultarDetalles();

        public bool CrearFactura(Factura factura);

        public void CrearCliente(Clientes cliente);

        public List<Clientes> ConsultarClientes();
        public List<Clientes> ConsultarClientes(int dni);

        public List<Producto> TraerProductos();
        public List<Producto> TraerProductos(string value);

        public List<Pagos> TraerPagos();

        public List<Barrios> TraerBarrios(); 
    }
}
