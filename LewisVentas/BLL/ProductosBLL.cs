using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LewisVentas.DAL;
using LewisVentas.ENTIDADES;

namespace LewisVentas.BLL
{
    class ProductosBLL
    {
        public static bool Guardar(Productos Producto)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                context.Producto.Add(Producto);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static bool Editar(Productos Producto)
        {
            bool estado = false;

            try
            {
                Context context = new Context();
                context.Entry(Producto).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static bool eliminar(int Id)
        {
           Productos Producto= null;
            bool estado = false;
            try
            {
                Context context = new Context();
                Producto = context.Producto.Find(Id);
                context.Producto.Remove(Producto);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Productos> Listar()
        {
            List<Productos> Poducto = new List<Productos>();
            Context context = new Context();
            Poducto = context.Producto.Select(reg => reg).ToList();

            return Poducto;
        }

        public static Productos Buscar(int Id)
        {
            Productos Producto = new Productos();
            try
            {
                Context context = new Context();
                Producto = context.Producto.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return Producto;

        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> filter)
        {
            List<Productos> lista = null;

            try
            {
                Context context = new Context();
                lista = context.Producto.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;

            }



            return lista;
        }

    }
}
