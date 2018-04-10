using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.View;
using LewisVentas.View.Login;

namespace LewisVentas
{
    static class Program
    {
        public static string TipoUsuario;
        public static int Id;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LayoutForm());
        }
    }
}
