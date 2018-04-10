using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.BLL;
using LewisVentas.ENTIDADES;
using System.Runtime.InteropServices;
using LewisVentas.View;

namespace LewisVentas.View.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
             if (ValidarErrores() == true)
              {
                  if (UsersBLL.Login(textBoxUsuario.Text, textBoxPass.Text) == true)
                  {
                      LayoutForm Layout = new LayoutForm();
                      Layout.Show();
                  }
                  else
                  {
                      labelPass.Visible = false;
                      labelUsuario.Visible = false;
                      labelError.Visible = true;
                  }
              }
          
        }

        private bool ValidarErrores()
        {
            bool estado = true;
            if (textBoxUsuario.Text == string.Empty) { 
                labelUsuario.Visible = true;
                 estado = false;
            }
            if (textBoxPass.Text == string.Empty) { 
                labelPass.Visible = true;
                estado = false;
            }
            return estado;
        }
    }
}
