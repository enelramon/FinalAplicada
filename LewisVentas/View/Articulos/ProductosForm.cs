using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.View.Articulos;
using LewisVentas.ENTIDADES;
using LewisVentas.BLL;


namespace LewisVentas.View.Articulos
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            CreateEditForm Guardar = new CreateEditForm();
            Guardar.ShowDialog();
            dataGridViewProducto.Rows.Clear();
            LlenaCampos();
        }

        private void LlenaCampos()
        {
            List<Productos> Producto = ProductosBLL.Listar();
            foreach (Productos producto in Producto)
            {
                dataGridViewProducto.Rows.Add(producto.IdProductos,producto.Nombre,producto.Codigo,producto.Stock,producto.Epecificacion,producto.IdCategorias, producto.PrecioCompra,producto.PrecioVenta);
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            LlenaCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducto.SelectedRows.Count > 0)
            {

                CreateEditForm Edit= new CreateEditForm();

                Edit.Id =(int) dataGridViewProducto.CurrentRow.Cells["ColumnId"].Value;
                Edit.Nombre = dataGridViewProducto.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                Edit.Codigo = dataGridViewProducto.CurrentRow.Cells["ColumnCodigo"].Value.ToString();
                Edit.stock = (int) dataGridViewProducto.CurrentRow.Cells["ColumnStock"].Value;
                Edit.IdCatgoria = (int) dataGridViewProducto.CurrentRow.Cells["ColumnCategoria"].Value;
                Edit.PrecioCompra =(float) dataGridViewProducto.CurrentRow.Cells["ColumnPrecioCompra"].Value;
                Edit.PrecioVentas =(float) dataGridViewProducto.CurrentRow.Cells["ColumnPrecioVenta"].Value;
                Edit.Especificacion = dataGridViewProducto.CurrentRow.Cells["ColumnEspecificacion"].Value.ToString();

                Edit.ShowDialog();
                dataGridViewProducto.Rows.Clear();
                LlenaCampos();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducto.SelectedRows.Count > 0)
            {

                int Id = (int)dataGridViewProducto.CurrentRow.Cells["ColumnId"].Value;
                if (ProductosBLL.eliminar(Id) == true)
                {
                    dataGridViewProducto.Rows.Clear();
                    LlenaCampos();
                    MessageBox.Show("Se elemino con exito!");
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar!");
                }



            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Productos> Producto = new List<Productos>();

            switch (comboBoxFiltrar.SelectedIndex)
            {
                case 0:
                    Producto = ProductosBLL.GetList(i => i.Nombre == textBoxBuscar.Text);
                    AddFiltrado(Producto);
                    break;
                case 1:

                    Producto = ProductosBLL.GetList(i => i.Codigo == textBoxBuscar.Text);
                    AddFiltrado(Producto);
                    break;
            

                default:
                    MessageBox.Show("Selecione un campo para filtrar");
                    break;
            }

            if (textBoxBuscar.Text == string.Empty)
            {
                dataGridViewProducto.Rows.Clear();
                LlenaCampos();
            }
        }

        private void AddFiltrado(List<Productos> Producto)
        {
            if (Producto.Count() > 0)
            {
                foreach (Productos producto in Producto)
                {
                    dataGridViewProducto.Rows.Clear();
                    dataGridViewProducto.Rows.Add(producto.IdProductos, producto.Nombre, producto.Codigo, producto.Stock, producto.Epecificacion, producto.IdCategorias, producto.PrecioCompra, producto.PrecioVenta);

                }
            }
            else
            {
                dataGridViewProducto.Rows.Clear();
            }
        }

       

       

        
    }
}
