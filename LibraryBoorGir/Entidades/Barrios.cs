using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBoorGir.Entidades
{
    public class Barrios
    {
        public int id_barrio { get; set; }
        public string descripcion { get; set; }

        public Barrios(int id_barrio, string descripcion)
        {
            this.id_barrio = id_barrio;
            this.descripcion = descripcion;
        }

    }
}
