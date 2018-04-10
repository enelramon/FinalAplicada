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
    class UsersBLL
    {
        public static bool Guardar(Users User)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                context.Usuario.Add(User);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
        public static bool Login(string NombreUsuario, string Pass)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                Users User = context.Usuario.FirstOrDefault(u => u.NombreUsuario == NombreUsuario);
                if(User != null)
                {
                    if (User.Pass == Pass)
                    {
                        Program.TipoUsuario = User.Tipo;
                        Program.Id = User.IdUsuario;
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                }
                else
                {
                    estado = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static Users Buscar(int Id)
        {
            Users articulos = new Users();
            try
            {
                Context context = new Context();
                articulos = context.Usuario.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return articulos;

        }

        public static List<Users> Listar()
        {
            List<Users> User = new List<Users>();
            Context context = new Context();
            User = context.Usuario.Select(reg => reg).ToList();

            return User;
        }

        public static bool Editar(Users usuarios)
        {
            bool estado = false;

            try
            {
                Context context = new Context();
                context.Entry(usuarios).State = EntityState.Modified;
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
            Users usuarios = null;
            bool estado = false;
            try
            {
                Context context = new Context();
                usuarios = context.Usuario.Find(Id);
                context.Usuario.Remove(usuarios);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Users> GetList(Expression<Func<Users, bool>> filter)
        {
            List<Users> lista = null;

            try
            {
                Context context = new Context();
                lista = context.Usuario.Where(filter).ToList();
                
            }
            catch (Exception)
            {
                throw;

            }

           

            return lista;
        }
    }
}
