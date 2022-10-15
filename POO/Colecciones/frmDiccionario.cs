using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Colecciones
{
    public partial class frmDiccionario : Form
    {
        Dictionary<string, Clases.Producto> productos = new Dictionary<string, Clases.Producto>();

        public frmDiccionario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Producto producto = new Clases.Producto();
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);

                productos.Add(txtCodigo.Text, producto);
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        
        void CargarDatos() {
            int pos = 0;
            dgvProductos.Rows.Clear();
            foreach (KeyValuePair<string, Clases.Producto> producto in productos) {
                dgvProductos.Rows.Add();
                dgvProductos.Rows[pos].Cells[0].Value = producto.Value.Codigo;
                dgvProductos.Rows[pos].Cells[1].Value = producto.Value.Nombre;
                dgvProductos.Rows[pos].Cells[2].Value = producto.Value.Precio;
                dgvProductos.Rows[pos].Cells[3].Value = producto.Value.Stock;
                pos++;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                if (productos.ContainsKey(codigo) == true) {
                    txtCodigo.Text = productos[codigo].Codigo;
                    txtNombre.Text = productos[codigo].Nombre;
                    txtPrecio.Text = Convert.ToString(productos[codigo].Precio);
                    txtStock.Text = Convert.ToString(productos[codigo].Stock);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                if (productos.ContainsKey(codigo) == true) {
                    productos.Remove(codigo);
                    CargarDatos();
                    Limpiar();
                } else {
                    MessageBox.Show("No existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
