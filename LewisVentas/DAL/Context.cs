using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LewisVentas.ENTIDADES;

namespace LewisVentas.DAL
{
    class Context:DbContext
    {
        public Context():base("ConStr")
        {

        }

        public DbSet<Users> Usuario { get; set; }
        public DbSet<Category> Categoria { get; set;}
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Productos> Producto { get; set;}
        public DbSet<Telefonos> Telefono { get; set; }
        public DbSet<Ventas> Venta { get; set; }
        public DbSet<DetalleVentas> DetaleVenta{ get; set; }
    }
}
