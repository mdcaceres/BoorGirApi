using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoorGirLibrary
{
    class Producto
    {
        public int idProducto { get; set; }
        public string nomProducto { get; set; }
        public double preUnitario { get; set; }
        public Producto(int idProducto, string nomProducto, double preUnitario)
        {
            this.idProducto = idProducto;
            this.nomProducto = nomProducto;
            this.preUnitario = preUnitario;
        }

    }
}

