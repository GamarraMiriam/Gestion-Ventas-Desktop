using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Cliente
    {
        public Cliente() {; }
        public Cliente(int pId,string pNombre, string pCUIT, string pEmail, string pTelefono, string pDireccion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.CUIT = pCUIT;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
