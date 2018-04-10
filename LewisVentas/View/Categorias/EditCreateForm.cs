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

namespace LewisVentas.View.Categorias
{
    public partial class EditCreateForm : Form
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public EditCreateForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarErrores() != false)
            {
                if (Nombre == null)
                {
                    if (CategoriasBLL.Guardar(LlenaClase()) == true)
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
                    Category Categoria = new Category();
                    Categoria.IdCategoria = Id;
                    Categoria.Nombre = textBoxNombre.Text;
                    Categoria.Descripcion = textBoxDescripcion.Text;


                    if (CategoriasBLL.Editar(Categoria) == true)
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

        private Category LlenaClase()
        {
           Category Categoria = new Category();
           Categoria.Nombre = textBoxNombre.Text;
           Categoria.Descripcion = textBoxDescripcion.Text;

            return Categoria;
        }

        private bool ValidarErrores()
        {
            bool estado = true;
            if (textBoxNombre.Text == string.Empty)
            {
                labelNombreError.Visible = true;
                estado = false;
            }
            if (textBoxDescripcion.Text == string.Empty)
            {
                labelDescipcionError.Visible = true;
                estado = false;
            }

            return estado;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCreateForm_Load(object sender, EventArgs e)
        {
            if (Nombre != null)
            {         
                textBoxNombre.Text = Nombre;
                textBoxDescripcion.Text = Descripcion;
            }
            else
            {

                labelTitulo.Text = "Crear nueva categoria";
                panelHeader.BackColor = Color.FromArgb(244, 81, 108);
            }
        }
    }
}
