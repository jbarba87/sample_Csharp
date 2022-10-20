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

                txtTotal.Text = Totalizar(dgvProductos, 2).ToString();
                txtTotalRegistros.Text = productos.Count.ToString();
                //txtTotalRegistros.Text = dgvProductos.Rows.Count.ToString();


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
                //throw;
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

        void GuardarArchivo(string ruta, string texto){
            StreamWriter sw = new StreamWriter(ruta);
            sw.Write(texto);
            sw.Close();
        }

        private void label5_Click(object sender, EventArgs e){
        }

        private void txtTotal_TextChanged(object sender, EventArgs e){
        }

        decimal Totalizar(DataGridView dgv, int numcolumna) {
            decimal total = 0;
            foreach (DataGridViewRow fila in dgv.Rows){
                total += Convert.ToDecimal(fila.Cells[numcolumna].Value);
            }
            return total;
        }

        bool SoloNumeros(int tecla){
            if ((tecla >= 48 && tecla <= 57) || tecla == 8)
            {
                return false;
            }
            else {
                return true;
            }
        }

        bool SoloLetras(int tecla){
            if ((tecla < 48 || tecla > 57) || tecla == 8){
                return false;
            }
            else{
                return true;
            }
        }


        private void txtStock_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = SoloNumeros(e.KeyChar);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e){
            e.Handled = SoloLetras(e.KeyChar);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
