using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Aplicaciones.NewFolder1
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Venta venta = new Clases.Venta();
                venta.Numero = txtNumero.Text;
                venta.Fecha = DateTime.Now;
                venta.Servicio = lstServicio.Text;
                venta.Cantidad = Convert.ToUInt16(txtCantidad.Text);

                decimal precio = 0;

                switch (venta.Servicio) { 
                    case "Alquiler PC": precio = 3; break;
                    case "Impresión": precio = 0.5m; break;
                    case "Scaneo": precio = 1; break;
                    case "Copia": precio = 0.3m; break;
                }
                venta.Total = venta.Cantidad * precio;
                venta.Descuento = venta.CalculaDescuento(venta.Cantidad, venta.Total);
                venta.Neto = venta.CalculaNeto(venta.Total, venta.Descuento);

                txtFecha.Text = Convert.ToString(venta.Fecha);
                txtTotal.Text = Convert.ToString(venta.Total);
                txtDescuento.Text = Convert.ToString(venta.Descuento);
                txtNeto.Text = Convert.ToString(venta.Neto);

                /*
                empleado.Nombres = txtNombre.Text;
                empleado.Cargo = cboCargos.Text;
                txtSueldo.Text = Convert.ToString(empleado.CalculaSueldo(empleado.Cargo));
                txtBonificacion.Text = Convert.ToString(empleado.CalculaBonificacion(empleado.Cargo));
                txtDescuento.Text = Convert.ToString(empleado.CalculaDescuento(Convert.ToDecimal(txtSueldo.Text)));
                txtNeto.Text = Convert.ToString(empleado.CalculaNeto(Convert.ToDecimal(txtSueldo.Text), Convert.ToDecimal(txtBonificacion.Text), Convert.ToDecimal(txtDescuento.Text)));
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
