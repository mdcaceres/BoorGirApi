using BooGir.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.DATA
{
    interface IDaoVendedores : IDao
    {
        bool Create(Vendedor vendedor);
    }
}
