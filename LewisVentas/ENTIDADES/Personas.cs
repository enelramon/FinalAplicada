using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    public class Personas
    {
        [Key]
        public int IdPersonas { get; set; }
        public string TipoPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int Rnc { get; set; }
        public virtual List<Telefonos> Telefono{ get; set; }


        public Personas()
        {
            this.IdPersonas = 0;
            this.Nombre = string.Empty;
            this.Apellidos = string.Empty;
            this.Direccion = string.Empty;
            this.Email = string.Empty;
            this.TipoPersona = string.Empty;
            this.Rnc = 0;
            this.Telefono= new List<Telefonos>();


        }

        public Personas(int Id, string nombre, string apellidos, string email, string tipo, string direccion, int rnc, List<Telefonos> detalles)
        {
            this.IdPersonas = Id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Email = email;
            this.TipoPersona = tipo;
            this.Rnc = rnc;
            this.Telefono = detalles;
          
        }
    }

}
