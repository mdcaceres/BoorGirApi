using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.Entidades
{
    class Factura
    {
		public int IdFactura { get; set; }
		public int IdVendedor { get; set; }
		public int DNI { get; set; }
		public int FormaPago { get; set; }
		public double Descuento { get; set; }
		public double total { get; set; }
		public List<DetalleFactura> Detalles { get; set; }
		public Factura()
		{
			Detalles = new List<DetalleFactura>();
		}

		public void AgregarDetalle(DetalleFactura detalle)
		{
			Detalles.Add(detalle);
		}
		public void QuitarDetalle(int indice)
		{
			Detalles.RemoveAt(indice);
		}
		public double CalcularTotal()
		{
			double total = 0;
			foreach (DetalleFactura detalle in Detalles)
			{
				total += detalle.CalcularSubtotal();
			}
			return total;
		}

	}
}
