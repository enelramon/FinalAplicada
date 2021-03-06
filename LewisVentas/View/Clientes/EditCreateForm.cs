﻿using System;
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

namespace LewisVentas.View.Clientes
{
    public partial class EditCreateForm : Form
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Email;
    
        public EditCreateForm()
        {
            InitializeComponent();
           
        }

        private void EditCreateForm_Load(object sender, EventArgs e)
        {
          
            if (Nombre != null)
            {
                textBoxApellido.Text = Apellido;
                textBoxNombre.Text = Nombre;
                textBoxDireccion.Text = Direccion;
                textBoxEmail.Text = Email;
                buttonNuevo.Visible = false;
                comboBoxTipo.Visible = false;
                textBoxNumero.Visible = false;
                labelTipo.Visible = false;
                labelNumero.Visible = false;
                dataGridViewTelefonos.Location = new Point(76, 217);


                List<Telefonos> Telefono = PersonasBLL.ListarTelefonos(Id);
                foreach (Telefonos telefono in Telefono)
                {
                    dataGridViewTelefonos.Rows.Add(telefono.IdTelefono,telefono.TipoTelefonos,telefono.Numeros);
                }



            }
            else
            {

                labelTitulo.Text = "Crear nuevo cliente";
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Falta el numero telefono!");
            }
            else
            {
                int Telefono = Convert.ToInt32(textBoxNumero.Text);
                string Tipo = comboBoxTipo.Text;
               

                dataGridViewTelefonos.Rows.Add("id",Tipo, Telefono);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarErrores() != false) { 
                if (Nombre == null)
                {
                    if (PersonasBLL.Guardar(LlenaClase()) == true)
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
                    Personas Persona = new Personas();
                    Persona.IdPersonas = Id;
                    Persona.Nombre = textBoxNombre.Text;
                    Persona.Email = textBoxEmail.Text;
                    Persona.Direccion = textBoxDireccion.Text;
                    Persona.Apellidos = textBoxApellido.Text;
                    Persona.TipoPersona = "Clientes";
                    int countData = dataGridViewTelefonos.RowCount - 1;
                    List<Telefonos> ArregloTelefono = new List<Telefonos>();

                    int row = 0;
                    while (row < countData)
                    {
                        Telefonos Telefono = new Telefonos();
                        Telefono.IdTelefono =(int) dataGridViewTelefonos.Rows[row].Cells[0].Value;
                        Telefono.IdPersonas = Id;
                        Telefono.TipoTelefonos = dataGridViewTelefonos.Rows[row].Cells[1].Value.ToString();
                        Telefono.Numeros = Convert.ToInt32(dataGridViewTelefonos.Rows[row].Cells[2].Value.ToString());

                        ArregloTelefono.Add(Telefono);
                        row++;
                    }
                    Persona.Telefono = ArregloTelefono;


                    if (PersonasBLL.Editar(Persona, Id) == true)
                    {
                        Nombre = string.Empty;
                        MessageBox.Show("Se edito con exito!");
                        this.Close();
                     }
                    else
                    {
                        MessageBox.Show("No se pudo editar el cliente");
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
            if (textBoxApellido.Text == string.Empty)
            {
                labelApellidoError.Visible = true;
                estado = false;
            }
            if (textBoxEmail.Text == string.Empty)
            {
                labelEmailError.Visible = true;
                estado = false;
            }
            if (textBoxDireccion.Text == string.Empty)
            {
                labelDireccionError.Visible = true;
                estado = false;
            }
            if (dataGridViewTelefonos.RowCount == 1)
            {
                labelTelefonosError.Visible = true;
                estado = false;
            }

            return estado;
        }

        private Personas LlenaClase()
        {
            Personas Persona = new Personas();
            Persona.Nombre = textBoxNombre.Text;
            Persona.Apellidos = textBoxApellido.Text;
            Persona.Direccion = textBoxDireccion.Text;
            Persona.Email  = textBoxEmail.Text;
            Persona.TipoPersona = "Clientes";
            Persona.Telefono = LlenaClaseTelefonos();



            return Persona;
        }
        public List<Telefonos> LlenaClaseTelefonos()
        {
            int countData = dataGridViewTelefonos.RowCount - 1;
            List<Telefonos> ArregloTelefono = new List<Telefonos>();

            int row = 0;
            while (row < countData)
            {
                Telefonos Telefono = new Telefonos();
                Telefono.TipoTelefonos = dataGridViewTelefonos.Rows[row].Cells[1].Value.ToString();
                Telefono.Numeros =Convert.ToInt32(dataGridViewTelefonos.Rows[row].Cells[2].Value);

                ArregloTelefono.Add(Telefono);
                row++;
            }


            return ArregloTelefono;
        }
    }
}
