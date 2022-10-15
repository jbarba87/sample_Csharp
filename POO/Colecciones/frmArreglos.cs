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

    public partial class frmArreglos : Form
    {
        Clases.Producto[] productos = new Clases.Producto[5];
        int contador = 0;

        public frmArreglos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar() {
            txtCodigo.Text = "";
            txtNombre.Clear();
            txtPrecio.Text = "0";
            txtStock.Text = "0";
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

                productos[contador] = producto;
                contador++;
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;

                MessageBox.Show("Registro grabado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                for (int i = 0; i < contador; i++) {
                    if (productos[i].Codigo == codigo) {
                        txtNombre.Text = Convert.ToString(productos[i].Nombre);
                        txtStock.Text = Convert.ToString(productos[i].Stock);
                        return;
                    }
                }
                Limpiar();
                MessageBox.Show("No existe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                for (int i = 0; i < contador; i++)
                {
                    if (productos[i].Codigo == codigo)
                    {
                        if (MessageBox.Show("Eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
                        productos[i].Codigo = "";
                        productos[i].Nombre = "";
                        productos[i].Precio = 0;
                        productos[i].Stock = 0;
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = productos;
                        Limpiar();

                        return;
                    }
                }

                MessageBox.Show("No existe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
        }
    }
}
