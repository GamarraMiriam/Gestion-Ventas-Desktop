using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public Vendedor(string pNombre, string pApellido, string pDNI)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
    }
}
