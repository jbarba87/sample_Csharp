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
    public partial class frmPilas : Form
    {
        Stack<Clases.Producto> pila = new Stack<Clases.Producto>();
        public frmPilas()
        {
            InitializeComponent();
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
            foreach (var producto in pila)
            {
                dgvProductos.Rows.Add();
                dgvProductos.Rows[pos].Cells[0].Value = producto.Codigo;
                dgvProductos.Rows[pos].Cells[1].Value = producto.Nombre;
                dgvProductos.Rows[pos].Cells[2].Value = producto.Precio;
                dgvProductos.Rows[pos].Cells[3].Value = producto.Stock;
                pos++;
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Producto producto = new Clases.Producto();
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);

                // Apilar
                pila.Push(producto);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = pila.Pop();
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
