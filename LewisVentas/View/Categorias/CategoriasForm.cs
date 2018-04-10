using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.View.Categorias;
using LewisVentas.BLL;
using LewisVentas.ENTIDADES;

namespace LewisVentas.View.Categorias
{
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            EditCreateForm Guardar = new EditCreateForm();
            Guardar.ShowDialog();
            dataGridViewCategorias.Rows.Clear();
            LlenaCampos();
        }

        private void LlenaCampos()
        {
            List<ENTIDADES.Category> Categoria = CategoriasBLL.Listar();
            foreach (ENTIDADES.Category categoria in Categoria)
            {
                dataGridViewCategorias.Rows.Add(categoria.IdCategoria, categoria.Nombre, categoria.Descripcion);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows.Count > 0)
            {

                EditCreateForm editar = new EditCreateForm();

                editar.Nombre = dataGridViewCategorias.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                editar.Id = (int)dataGridViewCategorias.CurrentRow.Cells["ColumnIdCategorias"].Value;
                editar.Descripcion = dataGridViewCategorias.CurrentRow.Cells["ColumnDescripcion"].Value.ToString();
                editar.ShowDialog();
                dataGridViewCategorias.Rows.Clear();
                LlenaCampos();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            LlenaCampos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows.Count > 0)
            {

                int Id = (int)dataGridViewCategorias.CurrentRow.Cells["ColumnIdCategorias"].Value;
                if (CategoriasBLL.eliminar(Id) == true)
                {
                    dataGridViewCategorias.Rows.Clear();
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
            List<Category> Categoria = new List<Category>();
          
            switch (comboBoxFiltrar.SelectedIndex)
            {
                case 0:
                    Categoria = CategoriasBLL.GetList(i => i.Nombre == textBoxBuscar.Text);
                    AddFiltrado(Categoria);
                    break;
                case 1:
                    int Datos = Int32.Parse(textBoxBuscar.Text);
                    Categoria = CategoriasBLL.GetList(i => i.IdCategoria == Datos);
                    AddFiltrado(Categoria);
                    break;

                default:
                    MessageBox.Show("Selecione un campo para filtrar");
                    break;
            }

            if (textBoxBuscar.Text == string.Empty)
            {
                dataGridViewCategorias.Rows.Clear();
                LlenaCampos();
            }
        }

        private void AddFiltrado(List<Category> Categoria)
        {
            if (Categoria.Count() > 0)
            {
                foreach (Category categoria in Categoria)
                {
                    dataGridViewCategorias.Rows.Clear();
                    dataGridViewCategorias.Rows.Add(categoria.IdCategoria, categoria.Nombre, categoria.Descripcion);

                }
            }
            else
            {
                dataGridViewCategorias.Rows.Clear();
            }
        }

    }
}
