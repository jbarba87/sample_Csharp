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

namespace POO.Archivos
{
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {
            InitializeComponent();
        }

        private void frmExplorador_Load(object sender, EventArgs e)
        {
            CargarDiscos();
        }
        void CargarDiscos() {
            cboDiscos.DataSource = DriveInfo.GetDrives();
        }

        private void cboDiscos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstCarpetas.DataSource = Directory.GetDirectories(cboDiscos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void lstCarpetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstArchivos.DataSource = Directory.GetFiles(lstCarpetas.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileInfo arch = new FileInfo(lstArchivos.Text);
                if (arch.Extension == ".jpg" || arch.Extension == ".gif" || arch.Extension == ".png") {
                    pcbImagen.Image = Image.FromFile(lstArchivos.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lstArchivos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(lstArchivos.Text);
            }
            catch (Exception ex)
            {

                //throw;
            }
        }
    }
}
