using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.View.VentasForm;
using LewisVentas.ENTIDADES;
using LewisVentas.BLL;

namespace LewisVentas.View.VentasForm
{
    public partial class MostarProductos : Form
    {
        public MostarProductos()
        {
            InitializeComponent();
        }

        private void dataGridViewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreateVentasForm.ProductoId = (int) dataGridViewShowProductos.Rows[dataGridViewShowProductos.CurrentRow.Index].Cells[0].Value;
            this.Close();
        }
        private void LlenaCampos()
        {
            List<Productos> Producto = ProductosBLL.Listar();
            foreach (Productos producto in Producto)
            {
                dataGridViewShowProductos.Rows.Add(producto.IdProductos, producto.Nombre, producto.Codigo, producto.Stock, producto.Epecificacion, producto.IdCategorias,producto.PrecioVenta);
            }
        }

        private void MostarProductos_Load(object sender, EventArgs e)
        {
            LlenaCampos();
        }
    }
}
