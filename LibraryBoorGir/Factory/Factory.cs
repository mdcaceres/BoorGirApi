
using LibraryBoorGir.DATA.servicios;
using LibraryBoorGir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.DATA.Factory
{
    public class Factory : AbstractFactory
    {
        public override IDaoVendedores CreateLoginDao()
        {
            return new LoginDao(); 
        }

        public override IDaoVendedores CreateVendedorDao()
        {
            return new VendedorDao(); 
        }

        public override IDaoFacturas CreateFacturasDao()
        {
            return new FacturaDao();
        }

        public override IDaoCliente CreateClientesDao()
        {
            return new ClientesDao(); 
        }

        public override IDao CreateProductosDao()
        {
            return new ProductosDao();
        }

        public override IDao CreatePagos()
        {
            return new PagosDao(); 
        }

        public override IDao CreateBarrios()
        {
            return new BarriosDao(); 
        }
    }
}
