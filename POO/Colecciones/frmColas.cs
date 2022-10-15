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
    public partial class frmColas : Form
    {
        Queue<Clases.Producto> cola = new Queue<Clases.Producto>();
        public frmColas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
        void CargarDatos()
        {
            int pos = 0;
            dgvProductos.Rows.Clear();  // borra todas las filas
            foreach (var producto in cola)
            {
                dgvProductos.Rows.Add();
                dgvProductos.Rows[pos].Cells[0].Value = producto.Codigo;
                dgvProductos.Rows[pos].Cells[1].Value = producto.Nombre;
                dgvProductos.Rows[pos].Cells[2].Value = producto.Precio;
                dgvProductos.Rows[pos].Cells[3].Value = producto.Stock;
                pos++;
            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Producto producto = new Clases.Producto();
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);

                //Encolar el producto
                cola.Enqueue(producto);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = cola.Dequeue();
                txtCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = Convert.ToString(producto.Precio);
                txtStock.Text = Convert.ToString(producto.Stock);
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
