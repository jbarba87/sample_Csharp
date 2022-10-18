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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
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
                GuardarArchivo(arch, txtEditor.Text);
                MessageBox.Show("Archivo guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        void GuardarArchivo(string ruta, string texto) {
            StreamWriter sw = new StreamWriter(ruta);
            sw.Write(texto);
            sw.Close();
        }



        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un dialogo para abrir archivos
                OpenFileDialog cd = new OpenFileDialog();
                cd.Filter = "Archivos de Texto (.txt) | *.txt";
                cd.ShowDialog();
                txtEditor.Text = AbrirArchivo(cd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        string AbrirArchivo(string ruta)
        {
            StreamReader sr = new StreamReader(ruta);
            return sr.ReadToEnd();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void dibujoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("pbrush.exe");

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
