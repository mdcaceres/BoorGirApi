using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooGir.Entidades
{
    class Vendedor
    {
        public string nom_vendedor { get; set; }
        public string ape_vendedor { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int id { get; set; }

        public Vendedor()
        {
            nom_vendedor = string.Empty;
            ape_vendedor = string.Empty;
            usuario = string.Empty;
            password = string.Empty;
            id = int.MinValue; 
        }

        public Vendedor(string nom_vendedor, string ape_vendedor, string usuario, string password)
        {
            this.nom_vendedor = nom_vendedor;
            this.ape_vendedor = ape_vendedor;
            this.usuario = usuario;
            this.password = password;
        }

    }
}
