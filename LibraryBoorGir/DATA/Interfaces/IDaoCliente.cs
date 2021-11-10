using LibraryBoorGir.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.Interfaces
{
    public interface IDaoCliente : IDao
    {
        void Create(Clientes cliente);
    }
}
