using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    class Users
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre  { get; set; }
        public string NombreUsuario { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        public Users()
        {
            this.IdUsuario = 0;
            this.Nombre = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Tipo = string.Empty;
            this.Email = string.Empty;
            this.Pass = string.Empty;
        }

        public Users(int Id, string nombre, string nombreUsuario, string email,string tipo, string pass)
        {
            this.IdUsuario = Id;
            this.Nombre = nombre;
            this.NombreUsuario = nombreUsuario;
            this.Tipo = tipo;
            this.Email = email;
            this.Pass = pass;
        }
    }

  
}
