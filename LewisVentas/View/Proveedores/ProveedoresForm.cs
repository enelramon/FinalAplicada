using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.View.Proveedores;
using LewisVentas.ENTIDADES;
using LewisVentas.BLL;


namespace LewisVentas.View.Proveedores
{
    public partial class ProveedoresForm : Form
    {
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {

                EditCreateProForm editar = new EditCreateProForm();

                editar.Nombre = dataGridViewProveedores.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                editar.Id = (int)dataGridViewProveedores.CurrentRow.Cells["ColumnId"].Value;
                editar.Nombre = dataGridViewProveedores.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                editar.Rnc = dataGridViewProveedores.CurrentRow.Cells["ColumnRnc"].Value.ToString();
                editar.Email = dataGridViewProveedores.CurrentRow.Cells["ColumnEmail"].Value.ToString();
                editar.Direccion = dataGridViewProveedores.CurrentRow.Cells["ColumnDireccion"].Value.ToString();
                editar.ShowDialog();
                dataGridViewProveedores.Rows.Clear();
                LlenaCampos();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            EditCreateProForm Guardar = new EditCreateProForm();
            Guardar.ShowDialog();
            dataGridViewProveedores.Rows.Clear();
            LlenaCampos();
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
            LlenaCampos();
        }

        private void LlenaCampos()
        {
            List<Personas> Persona = PersonasBLL.Listar(false);
            foreach (Personas persona in Persona)
            {
                dataGridViewProveedores.Rows.Add(persona.IdPersonas, persona.Nombre, persona.Rnc, persona.Direccion, persona.Email);
            }


        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {

                int Id = (int)dataGridViewProveedores.CurrentRow.Cells["ColumnId"].Value;
                if (PersonasBLL.eliminar(Id) == true)
                {
                    dataGridViewProveedores.Rows.Clear();
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
    }
}
