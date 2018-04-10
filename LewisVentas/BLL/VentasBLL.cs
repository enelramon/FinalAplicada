using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LewisVentas.ENTIDADES;
using LewisVentas.DAL;

namespace LewisVentas.BLL
{
    class VentasBLL
    {
        public static bool Guardar(Ventas Venta)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                context.Venta.Add(Venta);
/*
                foreach (DetalleVentas Detalle in Venta.Detalle)
                {
                    context.DetaleVenta.Add(Detalle);
                }*/
                context.SaveChanges();
                context.Dispose();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
    }
}
