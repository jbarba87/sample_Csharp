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
    public partial class frmCliente : Form
    {

        Clases.Cliente[] clientes = new Clases.Cliente[5];
        int contador = 0;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtRuc.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dtpFIngreso.Value = DateTime.Now;
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Cliente cliente = new Clases.Cliente();
                cliente.RUC = txtRuc.Text;
                cliente.Email = txtEmail.Text;
                //cliente.FechaIngreso = txtFIngreso.Text;
                cliente.FechaIngreso = dtpFIngreso.Value;
                cliente.Telefono = txtTelefono.Text;

                clientes[contador] = cliente;
                contador++;
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientes;

                MessageBox.Show("Registro grabado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dfvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtRuc.Text;
                for (int i = 0; i < contador; i++)
                {
                    if (clientes[i].RUC == codigo)
                    {
                        txtEmail.Text = clientes[i].Email;
                        txtTelefono.Text = clientes[i].Telefono;
                        dtpFIngreso.Value =clientes[i].FechaIngreso;
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
                string ruc = txtRuc.Text;
                for (int i = 0; i < contador; i++)
                {
                    if (clientes[i].RUC == ruc)
                    {
                        if (MessageBox.Show("Eliminar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
                        clientes[i].RUC = "";
                        clientes[i].Telefono = "";
                        clientes[i].Email = "";
                        clientes[i].FechaIngreso = DateTime.Now;
                        dgvClientes.DataSource = null;
                        dgvClientes.DataSource = clientes;
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

        private void dtpFIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
