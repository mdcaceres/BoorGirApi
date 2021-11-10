
using BooGir.DATA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.DATA.Factory
{
    abstract class AbstractFactory
    {
        public abstract IDaoVendedores CreateLoginDao();
        public abstract IDaoVendedores CreateVendedorDao();
        public abstract IDaoFacturas CreateFacturasDao();
        public abstract IDaoCliente CreateClientesDao();
        public abstract IDao CreateProductosDao();

    }
}
