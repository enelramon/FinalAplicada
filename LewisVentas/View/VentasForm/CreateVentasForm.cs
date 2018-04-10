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
using LewisVentas.BLL;
using LewisVentas.ENTIDADES;

namespace LewisVentas.View.VentasForm
{
    public partial class CreateVentasForm : Form
    {
        public static int ProductoId;
        float total;
        float subTotal;
        int numeroFactura;
        public CreateVentasForm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void CreateVentasForm_Load(object sender, EventArgs e)
        {
            LlenaCampos();
            List<Personas> Per = new List<Personas>();
            Per = PersonasBLL.Listar(true);

            comboBoxClientes.DisplayMember = "Nombre";
            comboBoxClientes.ValueMember = "IdPersonas";
            comboBoxClientes.DataSource = Per;

        }

        private void LlenaCampos()
        {
            comboBoxFacturas.SelectedItem= "Ticket";
            comboBoxPagos.SelectedItem = "Contado";
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            MostarProductos Guardar = new MostarProductos();
            Guardar.ShowDialog();
            Buscar();
        }
        public void Buscar()
        {
            try
            {
                Productos Pro = ProductosBLL.Buscar(ProductoId);
                if (Pro != null)
                {   
                    textBoxNombre.Text = Pro.Nombre;
                    textBoxPrecio.Text = Pro.PrecioVenta.ToString();
                    textBoxStock.Text = Pro.Stock.ToString();

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text != string.Empty) {
                LlenaCampo();
            }
            else
            {
                MessageBox.Show("Agregue una cantidad");
            }
           
            

        }
        private void Limpiar()
        {
            textBoxNombre.Text = string.Empty;
            textBoxPrecio.Text = string.Empty;
            textBoxStock.Text = string.Empty;
        }

        private void LlenaCampo()
        {   
            subTotal = float.Parse(textBoxCantidad.Text) * float.Parse(textBoxPrecio.Text);
            total += subTotal;
            labelTotal.Text = total.ToString();
            dataGridViewVentas.Rows.Add(ProductoId,textBoxNombre.Text, textBoxCantidad.Text, textBoxStock.Text, textBoxPrecio.Text, subTotal);
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            if (VentasBLL.Guardar(LlenaClase())== true) {

                MessageBox.Show("guardo con exito!");
            }
            else
            {
                MessageBox.Show("Error, Intentelo de nuevo");
            }
        }
           
          
        private Ventas  LlenaClase()
        {
            Ventas Ven = new Ventas();
            Ven.Credito = comboBoxPagos.SelectedItem.ToString();
            Ven.IdPersona=(int) comboBoxClientes.SelectedValue;
            Ven.TotalVenta = float.Parse(labelTotal.Text);
            Ven.Numero =int.Parse(textBoxNumero.Text);
            Ven.Fecha = dateTimePickerFecha.Value;
            Ven.Serie = int.Parse(textBoxSerie.Text);
            Ven.Detalle = LlenaClaseDetalles();
            return Ven;   
        }

        private List<DetalleVentas> LlenaClaseDetalles()
        {
           
                int countData = dataGridViewVentas.RowCount - 1;
                List<DetalleVentas> ArregloVentas = new List<DetalleVentas>();

                int row = 0;
                while (row < countData)
                {
               
                DetalleVentas Dt= new DetalleVentas();
                    Dt.IdProductos =(int) dataGridViewVentas.Rows[row].Cells[0].Value;
                
                    Dt.Cantidad = int.Parse(dataGridViewVentas.Rows[row].Cells[2].Value.ToString());
                    Dt.PrecioVentas =float.Parse(dataGridViewVentas.Rows[row].Cells[4].Value.ToString());
                   
                   ArregloVentas.Add(Dt);
                    row++;
                }


                return ArregloVentas;
            
        }
    }
}
