using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.ENTIDADES;
using LewisVentas.BLL;


namespace LewisVentas.View.Articulos
{
    public partial class CreateEditForm : Form
    {
        public int Id;
        public string Nombre;
        public string Codigo;
        public int stock;
        public float PrecioCompra;
        public float PrecioVentas;
        public string Especificacion;
        public int IdCatgoria;

        public CreateEditForm()
        {
            InitializeComponent();
        }

        private void CreateEditForm_Load(object sender, EventArgs e)
        {
            List<Category> Categoria = new List<Category>();
            Categoria = CategoriasBLL.Listar();

            comboBoxCategorias.DisplayMember = "Nombre";
            comboBoxCategorias.ValueMember = "IdCategoria";
            comboBoxCategorias.DataSource = Categoria;

            if (Nombre != null)
            {
                textBoxNombre.Text = Nombre;
                textBoxCodigo.Text = Codigo;
                textBoxStock.Text = stock.ToString();
                textBoxPrecioCompra.Text = PrecioCompra.ToString();
                textBoxPrecioVenta.Text =PrecioVentas.ToString();
                comboBoxCategorias.SelectedValue = IdCatgoria;
                comboBoxEspesificaciones.SelectedItem= Especificacion;
            }
            else
            {

                labelTitulo.Text = "Crear nueva categoria";
                panelHeader.BackColor = Color.FromArgb(244, 81, 108);

              
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Productos LlenaClase()
        {
            Productos Producto = new Productos();
            Producto.Nombre = textBoxNombre.Text;
            Producto.Codigo = textBoxCodigo.Text;
            Producto.Stock =Int32.Parse(textBoxStock.Text);
            Producto.Epecificacion =(string) comboBoxEspesificaciones.SelectedItem;
            Producto.IdCategorias =(int) comboBoxCategorias.SelectedValue;
            Producto.PrecioCompra = float.Parse(textBoxPrecioCompra.Text);
            Producto.PrecioVenta = float.Parse(textBoxPrecioVenta.Text);

            return Producto;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarErrores() != false)
            {
                if (Nombre == null)
                {
                    if (ProductosBLL.Guardar(LlenaClase()) == true)
                    {
                        this.Close();
                        MessageBox.Show("Guardo con exito!");
                    }

                    else
                    {
                        MessageBox.Show("Error. No se pudo guardar");
                    }
                }
                else
                {
                    Productos Producto = new Productos();
                    Producto.IdProductos = Id;
                    Producto.Nombre = textBoxNombre.Text;
                    Producto.Codigo = textBoxCodigo.Text;
                    Producto.Stock = Int32.Parse(textBoxStock.Text);
                    Producto.Epecificacion = (string)comboBoxEspesificaciones.SelectedItem;
                    Producto.IdCategorias = (int)comboBoxCategorias.SelectedValue;
                    Producto.PrecioCompra = float.Parse(textBoxPrecioCompra.Text);
                    Producto.PrecioVenta = float.Parse(textBoxPrecioVenta.Text);


                    if (ProductosBLL.Editar(Producto) == true)
                    {

                        MessageBox.Show("Se edito con exito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar la categoria");
                    }
                }
            }
        }

        private bool ValidarErrores()
        {

            bool estado = true;
            if (textBoxNombre.Text == string.Empty)
            {
                labelNombreError.Visible = true;
                estado = false;
            }
            if (textBoxCodigo.Text == string.Empty)
            {
                labelCodigoError.Visible = true;
                estado = false;
            }
            if (textBoxStock.Text == string.Empty)
            {
                labelStockError.Visible = true;
                estado = false;
            }
            if (textBoxPrecioCompra.Text == string.Empty)
            {
                labelPrecioCompraError.Visible = true;
                estado = false;
            }
            if (textBoxPrecioVenta.Text == string.Empty)
            {
                labelPreciVentaError.Visible = true;
                estado = false;
            }
            if (comboBoxCategorias.Text == string.Empty)
            {
                labelCategoriaError.Visible = true;
                estado = false;
            }
            if (comboBoxEspesificaciones.Text == string.Empty)
            {
                labelEspecificacion.Visible = true;
                estado = false;
            }

            return estado;
        }
    }
}
