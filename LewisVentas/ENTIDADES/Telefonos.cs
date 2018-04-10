using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    public class Telefonos
    {
        [Key]
        public int IdTelefono { get; set; }
        public int IdPersonas { get; set; }
        public string TipoTelefonos { get; set; }
        public int Numeros { get; set; }
       

        public Telefonos()
        {
            this.IdTelefono = 0;
            this.TipoTelefonos = string.Empty;
            this.Numeros = 0;
            this.IdPersonas = 0;
        }

        public Telefonos(int Id, string Tipo, int idPersona, int Numeros)
        {
            this.IdTelefono = Id;
            this.TipoTelefonos = Tipo;
            this.Numeros = Numeros;
            this.IdPersonas = idPersona;
        }
    }
}
