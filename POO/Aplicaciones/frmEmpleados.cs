using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Aplicaciones
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Empleado empleado = new Clases.Empleado();
                empleado.DNI = txtCodigo.Text;
                empleado.Nombres = txtNombre.Text;
                empleado.Cargo = cboCargos.Text;
                txtSueldo.Text = Convert.ToString(empleado.CalculaSueldo(empleado.Cargo));
                txtBonificacion.Text = Convert.ToString(empleado.CalculaBonificacion(empleado.Cargo));
                txtDescuento.Text = Convert.ToString(empleado.CalculaDescuento(Convert.ToDecimal(txtSueldo.Text)));
                txtNeto.Text = Convert.ToString(empleado.CalculaNeto(Convert.ToDecimal(txtSueldo.Text), Convert.ToDecimal(txtBonificacion.Text), Convert.ToDecimal(txtDescuento.Text)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
