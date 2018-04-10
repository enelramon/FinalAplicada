using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    class Productos
    {
        [Key]
        public int IdProductos { get; set; }
        
        public int IdCategorias { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Epecificacion { get; set; }
        public int Stock { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }

        public Productos()
        {
            this.IdProductos = 0;
            this.IdCategorias = 0;
            this.Nombre = string.Empty;
            this.Codigo = string.Empty;
            this.Epecificacion = string.Empty;
            this.Stock = 0;
            this.PrecioCompra = 0;
            this.PrecioVenta = 0;


        }

        public Productos(int Id, int idCategorias, string nombre, string codigo, string especificacion, int stock, float precioCompra, float precioVentas)
        {
            this.IdProductos =Id;
            this.IdCategorias = idCategorias;
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Epecificacion = especificacion;
            this.Stock = stock;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVentas;


        }
    }


}
