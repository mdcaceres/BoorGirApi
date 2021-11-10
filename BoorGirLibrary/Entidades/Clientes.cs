using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoorGirLibrary
{
    class Clientes
    {
        public int Dni { get; set; }
        public int Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdBarrio { get; set; }
        public string Direccion { get; set; }

        public Clientes(int dni, int telefono, string nombre, string apellido, int idBarrio, string direccion)
        {
            Dni = dni;
            Telefono = telefono;
            Nombre = nombre;
            Apellido = apellido;
            IdBarrio = idBarrio;
            Direccion = direccion;
        }
    }
}
