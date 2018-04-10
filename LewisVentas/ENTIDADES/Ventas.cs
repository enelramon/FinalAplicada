using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LewisVentas.ENTIDADES
{
    class Ventas
    {
        [Key]
        public int IdVentas { get; set; }
        public int IdPersona  { get; set; }
        public int IdUser{ get; set; }
        public int Serie { get; set; }
        public int Numero { get; set; }
        public string Credito { get; set; }
        public float TotalVenta { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<DetalleVentas> Detalle { get; set; }

        public Ventas()
        {
            this.IdVentas = 0;
            this.IdPersona = 0;
            this.IdUser = 0;
            this.Serie = 0;
            this.Numero = 0;
            this.Credito = string.Empty;
            this.TotalVenta = 0;
            this.Fecha = DateTime.Now;
            this.Detalle = new List<DetalleVentas>();
        }

        public Ventas(int Id, int idPersona, int idUser, int serie, int numero, string credito, float total, DateTime fecha, List<DetalleVentas> detalle)
        {
            this.IdVentas = Id;
            this.IdPersona = idPersona;
            this.IdUser = idUser;
            this.Serie = serie;
            this.Numero = numero;
            this.Credito = credito;
            this.TotalVenta = total;
            this.Fecha = fecha;
            this.Detalle = detalle;
        }


    }
}
