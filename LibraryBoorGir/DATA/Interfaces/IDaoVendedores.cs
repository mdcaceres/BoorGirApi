using LibraryBoorGir.Entidades;
using LibraryBoorGir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.DATA
{
    public interface IDaoVendedores : IDao
    {
        bool Create(Vendedor vendedor);
    }
}
