using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEmpresa : Cliente
    {
        public ClienteEmpresa(string pNombre, string pContacto, string pCUIT, string pEmail, string pTelefono, string pDireccion, string pFotojpg)
        {
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Contacto = pContacto;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.Fotojpg = pFotojpg;
        }
        public ClienteEmpresa() {; }
        public string Contacto { get; set; }
        public string Fotojpg { get; set; }
    }
}
