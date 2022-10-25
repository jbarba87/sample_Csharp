using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Aplicaciones.frmPagos frm = new Aplicaciones.frmPagos();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 

                Archivos.frmExplorador frm = new Archivos.frmExplorador();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void hilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Hilos.frmHilos frm = new Hilos.frmHilos();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
