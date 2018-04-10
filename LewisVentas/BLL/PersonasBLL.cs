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
    class PersonasBLL
    {

        public static bool Guardar(Personas Persona)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                context.Persona.Add(Persona);

                foreach (Telefonos Telefono in Persona.Telefono)
                {
                    context.Telefono.Add(Telefono);
                }
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
       
        public static Personas Buscar(int Id)
        {
            Personas Persona = new Personas();
            try
            {
                Context context = new Context();
                Persona = context.Persona.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return Persona;

        }

      

        public static List<Personas> Listar(bool Estado)
        {
            string TipoClientes;
            if (Estado== true)
            {
                TipoClientes = "Clientes";
            }
            else
            {
                TipoClientes = "Proveedores";
            }

            List<Personas> User = new List<Personas>();
            Context context = new Context();
            User = context.Persona.Select(i => i).Where(i => i.TipoPersona == TipoClientes).ToList();

            return User;
        }

       
        public static bool Editar(Personas Persona, int Id)
        {
            bool estado = false;
          

            try
            {
                Context context = new Context();
                context.Entry(Persona).State = EntityState.Modified;

                foreach (Telefonos Telefono in Persona.Telefono)
                {
                    context.Entry(Telefono).State = EntityState.Modified;
                }
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static List<Telefonos> ListarTelefonos(int Id)
        {

            List<Telefonos> Telefono = new List<Telefonos>();
            Context context = new Context();
            Telefono = context.Telefono.Select(i => i).Where(i => i.IdPersonas == Id).ToList();

            return Telefono;
        }


        public static bool eliminar(int Id)
        {
            Personas Persona = null;
            List<Telefonos> Telefono = ListarTelefonos(Id);
            bool estado = false;
            try
            {
                Context context = new Context();
                Persona = context.Persona.Find(Id);
                context.Persona.Remove(Persona);
               /* foreach(Telefonos Tel in Telefono)
                {
                    context.Telefono.Remove(Tel);
                }*/
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> filter)
        {
            List<Personas> lista = null;

            try
            {
                Context context = new Context();
                lista = context.Persona.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;

            }



            return lista;
        }

      
      

    }
}

