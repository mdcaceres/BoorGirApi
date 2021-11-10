using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.Entidades
{
    class DetalleFactura
    {
		public Producto Producto { get; set; }
		public int Cantidad { get; set; }
		public DetalleFactura(Producto producto, int cantidad)
		{
			Producto = producto;
			Cantidad = cantidad;
		}

		public double CalcularSubtotal()
		{
			return (Producto.preUnitario * Cantidad);
		}
	}
}
