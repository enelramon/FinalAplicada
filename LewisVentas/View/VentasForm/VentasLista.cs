using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LewisVentas.View.VentasForm
{
    public partial class VentasLista : Form
    {
        public VentasLista()
        {
            InitializeComponent();
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            LayoutForm Ver = new LayoutForm();
            Ver.PonerFormEnPanel(new CreateVentasForm());
            Ver.Show();
        }
   
    }
}
