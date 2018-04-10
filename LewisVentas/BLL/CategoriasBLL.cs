using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LewisVentas.ENTIDADES;
using LewisVentas.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace LewisVentas.BLL
{
    class CategoriasBLL
    {
        public static bool Guardar(Category Categoria)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                context.Categoria.Add(Categoria);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
       
        public static Category Buscar(int Id)
        {
            Category Categoria = new Category();
            try
            {
                Context context = new Context();
              Categoria = context.Categoria.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return Categoria;

        }

        public static List<Category> Listar()
        {
            List<Category> Categoria= new List<Category>();
            Context context = new Context();
            Categoria = context.Categoria.Select(reg => reg).ToList();

            return Categoria;
        }

        public static bool Editar(Category Categoria)
        {
            bool estado = false;

            try
            {
                Context context = new Context();
                context.Entry(Categoria).State = EntityState.Modified;
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
            Category Categoria = null;
            bool estado = false;
            try
            {
                Context context = new Context();
               Categoria = context.Categoria.Find(Id);
                context.Categoria.Remove(Categoria);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Category> GetList(Expression<Func<Category, bool>> filter)
        {
            List<Category> lista = null;

            try
            {
                Context context = new Context();
                lista = context.Categoria.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;

            }



            return lista;
        }
    }
}
