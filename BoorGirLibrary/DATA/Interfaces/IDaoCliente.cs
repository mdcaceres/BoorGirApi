
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoorGirLibrary
{
    interface IDaoCliente : IDao
    {
        void Create(Clientes cliente);
    }
}
