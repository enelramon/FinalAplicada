using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    class DetalleVentas
    {
        [Key]
        public int IdDetalles { get; set; }
        public int IdVentas { get; set; }
        public int IdProductos { get; set; }
        public int Cantidad { get; set; }
        public float PrecioVentas { get; set; }
        public float Descuento { get; set; }

        public DetalleVentas()
        {
            this.IdDetalles = 0;
            this.IdVentas = 0;
            this.IdProductos = 0;
            this.Cantidad = 0;
            this.PrecioVentas = 0;
            this.Descuento = 0;
        }

        public DetalleVentas(int Id, int IdVentas, int IdProductos, int Cantidad, float preciVentas, float descuento)
        {
            this.IdDetalles = Id;
            this.IdVentas = IdVentas;
            this.IdProductos = IdProductos;
            this.Cantidad = Cantidad;
            this.PrecioVentas = preciVentas;
            this.Descuento = descuento;
        }
    }
}
