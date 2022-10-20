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
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            borraTodo();
        }

        void borraTodo() {
            txtCodigo.Clear();
            txtNombre.Clear();
            cboCargo.Text = "";
            txtBasico.Clear();
            txtBonificacion.Clear();
            txtDescuento.Clear();
            txtNeto.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string cargo = cboCargo.Text;
            decimal basico = 0;
            switch (cargo) {
                case "Gerente":
                    basico = 5000;
                    break;
                case "Jefe":
                    basico = 2500;
                    break;
                case "Supervisor":
                    basico = 1200;
                    break;
                case "Otro":
                    basico = 860;
                    break;
            }

            txtBasico.Text = Convert.ToString(basico);

            // Bonificacion
            string area = lstArea.Text;
            decimal bonificacion = 0;
            switch (area){
                case "Ventas":
                    bonificacion = basico*0.025m;
                    break;
                case "Sistemas":
                    bonificacion = basico * 0.05m;
                    break;
                case "RRHH":
                    bonificacion = basico * 0.045m;
                    break;
                case "Produccion":
                    bonificacion = basico * 0.1m;
                    break;
            }
            // Es antiguo
            DateTime hoy = DateTime.Now;
            DateTime FIngreso = dtpFechaContratado.Value;

            TimeSpan Duracion = hoy - FIngreso;

            if (Duracion.TotalDays < (365 * 3))
            {
                bonificacion = 0;
            }

            txtBonificacion.Text = Convert.ToString(bonificacion);
            //Console.WriteLine("{0}", Duracion.ToString());

            // Descuento
            decimal descuento = 0;
            if (rbPlanilla.Checked) {
                descuento = basico * 0.18m;
            }
            if (rbContratado.Checked)
            {
                descuento = basico * 0.08m;
            }
            txtDescuento.Text = Convert.ToString(descuento);

            decimal neto = basico + bonificacion - descuento;
            txtNeto.Text = Convert.ToString(neto);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpFechaContratado_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            // Iniciales
            cboCargo.Text = "Otro";
            lstArea.Text = "Ventas";
            rbPlanilla.Checked = true;

        }
    }
}
