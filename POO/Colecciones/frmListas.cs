using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POO.Colecciones
{
    public partial class frmListas : Form
    {
        public List <Clases.Producto> productos = new List<Clases.Producto>();
        public frmListas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtCodigo.Focus();
        }
        void Limpiar() {
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

                productos.Add(producto);
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                var producto = productos.Where(p => p.Codigo == codigo).SingleOrDefault();
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else {
                    txtNombre.Text = producto.Nombre;
                    txtPrecio.Text = Convert.ToString(producto.Precio);
                    txtStock.Text = Convert.ToString(producto.Stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                var producto = productos.Where(p => p.Codigo == codigo).SingleOrDefault();
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado");
                    Limpiar();
                }
                else
                {
                    productos.Remove(producto);
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = productos;
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                // crear un cuadro de dialogo para guardar archivos 
                SaveFileDialog cd = new SaveFileDialog();

                // Filtrar solo para visualizar archivos de texto
                cd.Filter = "Archivos de texto (*.txt) | *.txt";

                //Mostrar la ventana de dialogo
                cd.ShowDialog();

                // Capturar el nombre del archivo
                string arch = cd.FileName;
                //GuardarArchivo(arch, txtEditor.Text);

                string texto = "";
                foreach (Clases.Producto producto in productos) {
                    texto += producto.Codigo + " " + producto.Nombre + " " + Convert.ToString(producto.Precio) + " " + Convert.ToString(producto.Stock) + "\n";

                }
                GuardarArchivo(arch, texto);
                MessageBox.Show("Archivo guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        void GuardarArchivo(string ruta, string texto)
        {
            StreamWriter sw = new StreamWriter(ruta);
            sw.Write(texto);
            sw.Close();
        }
    }
}
