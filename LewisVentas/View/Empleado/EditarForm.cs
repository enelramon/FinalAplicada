using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LewisVentas.ENTIDADES;
using LewisVentas.BLL;



namespace LewisVentas.View.Empleado
{
    public partial class EditarForm : Form
    {
        public int Id;
        public string Nombre;
        public string NombreUsuario;
        public string Email;
        public string Tipo;
        public string Pass;
        public EditarForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void EditarForm_Load(object sender, EventArgs e)
        {
            if (Nombre != null)
            {
                textBoxNombre.Text = Nombre;
                textBoxEmail.Text = Email;
                textBoxTipo.Text = Tipo;
                textBoxPass.Text = Pass;
                textBoxUsuarios.Text = NombreUsuario;
            }
            else
            {
               
                labelTitulo.Text = "Crear nuevo empleado";
                panelHeader.BackColor =Color.FromArgb(244, 81, 108); 
            }
        }

        private void EditarForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(ValidarErrores() != false)
            {
               
                if (Nombre == null)
                {
                    if (UsersBLL.Guardar(LlenaClase()) == true)
                    {

                        MessageBox.Show("Se guardo con exito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el empleado");
                    }
                }
                else
                {
                    Users usuario = new Users();
                    usuario.IdUsuario = Id;
                    usuario.Nombre = textBoxNombre.Text;
                    usuario.Email = textBoxEmail.Text;
                    usuario.Tipo = textBoxTipo.Text;
                    usuario.Pass = textBoxPass.Text;
                    usuario.NombreUsuario = textBoxUsuarios.Text;

                    if (UsersBLL.Editar(usuario) == true)
                    {
                        Nombre = string.Empty;
                        MessageBox.Show("Se edito con exito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo editar el empleado");
                    }
                }
            }
        }

        private Users LlenaClase()
        {
            Users usuario = new Users();

            usuario.Nombre = textBoxNombre.Text;
            usuario.Email= textBoxEmail.Text;
            usuario.Tipo= textBoxTipo.Text;
            usuario.Pass = textBoxPass.Text;
            usuario.NombreUsuario = textBoxUsuarios.Text;

            return usuario;
        }

        private bool ValidarErrores()
        {
            bool estado = true;
            if (textBoxNombre.Text == string.Empty) {
                labelNombreError.Visible = true;
                estado = false;
            }
            if (textBoxUsuarios.Text == string.Empty)
            {
                labelUsuarioError.Visible = true;
                estado = false;
            }
            if (textBoxEmail.Text == string.Empty)
            {
                labelEmailError.Visible = true;
                estado = false;
            }
            if (textBoxTipo.Text == string.Empty)
            {
                labelTipoError.Visible = true;
                estado = false;
            }
            if (textBoxPass.Text == string.Empty)
            {
                labelContraseñaErrro.Visible = true;
                estado = false;
            }
            return estado;
        }
    }
}
