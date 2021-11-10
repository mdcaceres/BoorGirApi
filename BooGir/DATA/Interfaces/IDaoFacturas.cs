using BooGir.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.DATA
{
    interface IDaoFacturas : IDao
    {
        bool Create(Factura miFactura);
        DataTable ReturnTable(CommandType type, string CommandText, string name0, string value0, string name1, string value1);
    }
}
