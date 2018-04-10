using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.View.Clientes;
using LewisVentas.BLL;
using LewisVentas.ENTIDADES;

namespace LewisVentas.View.Clientes
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {

                EditCreateForm editar = new EditCreateForm();
                
                editar.Nombre = dataGridViewClientes.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                editar.Id = (int)dataGridViewClientes.CurrentRow.Cells["ColumnId"].Value;
                editar.Nombre = dataGridViewClientes.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                editar.Apellido = dataGridViewClientes.CurrentRow.Cells["ColumnApellido"].Value.ToString();
                editar.Email = dataGridViewClientes.CurrentRow.Cells["ColumnEmail"].Value.ToString();
                editar.Direccion = dataGridViewClientes.CurrentRow.Cells["ColumnDireccion"].Value.ToString();
                editar.ShowDialog();
                dataGridViewClientes.Rows.Clear();
                LlenaCampos();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }
        
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            EditCreateForm Guardar = new EditCreateForm();
            Guardar.ShowDialog();
            dataGridViewClientes.Rows.Clear();
            LlenaCampos();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            LlenaCampos();
        }
        private void LlenaCampos()
        {
            List<Personas> Persona = PersonasBLL.Listar(true);
            foreach (Personas persona in Persona)
            {
                dataGridViewClientes.Rows.Add(persona.IdPersonas,persona.Nombre, persona.Apellidos, persona.Direccion, persona.Email);
            }


        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {

                int Id = (int)dataGridViewClientes.CurrentRow.Cells["ColumnId"].Value;
                if (PersonasBLL.eliminar(Id) == true)
                {
                    dataGridViewClientes.Rows.Clear();
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
            List<Personas> Persona = new List<Personas>();

            
            switch (comboBoxFiltrar.SelectedIndex)
            {
                case 0:
                    Persona = PersonasBLL.GetList(i => i.Nombre == textBoxBuscar.Text);
                    AddFiltrado(Persona);
                    break;
                case 1:
                    Persona = PersonasBLL.GetList(i => i.Apellidos == textBoxBuscar.Text);
                    AddFiltrado(Persona);
                    break;
                case 2:
                    int Id = Int32.Parse(textBoxBuscar.Text);
                    Persona = PersonasBLL.GetList(i => i.IdPersonas == Id);
                    AddFiltrado(Persona);
                    break;


                default:
                    MessageBox.Show("Selecione un campo para filtrar");
                    break;
            }

            if (textBoxBuscar.Text == string.Empty)
            {
                dataGridViewClientes.Rows.Clear();
                LlenaCampos();
            }
        }
        private void AddFiltrado(List<Personas> Persona)
        {
            if (Persona.Count() > 0)
            {
             
                foreach (Personas persona in Persona)
                {
                    dataGridViewClientes.Rows.Clear();
                    dataGridViewClientes.Rows.Add(persona.IdPersonas, persona.Nombre, persona.Apellidos, persona.Direccion, persona.Email);

                }
            }
            else
            {
               
                dataGridViewClientes.Rows.Clear();
            }
        }
    }
}
