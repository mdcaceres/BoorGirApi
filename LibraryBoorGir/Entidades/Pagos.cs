using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.Entidades
{
    public class Pagos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Pagos(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
