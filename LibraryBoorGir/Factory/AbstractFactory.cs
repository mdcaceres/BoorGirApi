using LibraryBoorGir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.DATA.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IDaoVendedores CreateLoginDao();
        public abstract IDaoVendedores CreateVendedorDao();
        public abstract IDaoFacturas CreateFacturasDao();
        public abstract IDaoCliente CreateClientesDao();
        public abstract IDao CreateProductosDao();
        public abstract IDao CreatePagos();

        public abstract IDao CreateBarrios();

    }
}
