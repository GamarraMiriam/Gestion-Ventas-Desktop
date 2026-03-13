using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo : Cliente
    {
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, string pEmail, string pTelefono, string pDireccion)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;

        }
        public string Apellido { get; set; }
    }
}
