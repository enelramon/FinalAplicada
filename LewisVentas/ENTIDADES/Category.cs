using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    class Category
    {   [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Category()
        {
            this.IdCategoria = 0;
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
        }
        public Category(int Id, string nombre, string descripcion)
        {
            this.IdCategoria = Id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }


    }
}
