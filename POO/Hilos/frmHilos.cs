using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace POO.Hilos
{
    public partial class frmHilos : Form
    {
        public frmHilos()
        {
            InitializeComponent();
        }

        // Creacion de hilos
        Thread hilo1 = null;
        Thread hilo2 = null;
        Thread hilo3 = null;

        private void btnIniciar_Click(object sender, EventArgs e){

            // Desactivar regla que impide que un hilo1 pueda acceder a recursos que 
            // se ejecutan en otro hilo
            CheckForIllegalCrossThreadCalls = false;
            // inicializar hilos
            hilo1 = new Thread(Tarea1);
            hilo2 = new Thread(Tarea2);
            hilo3 = new Thread(Tarea3);

            // Correr los hilos
            Parametros par = new Parametros();
            par.Inicio = 1;
            par.Fin = 1000000;

            hilo1.Priority = ThreadPriority.Highest;

            hilo1.Start(par);
            hilo2.Start(par);
            hilo3.Start(par);


        }

        void Tarea1(object p) {
            Parametros parametros = p as Parametros;
            progressBar1.Minimum = parametros.Inicio;
            progressBar1.Maximum = parametros.Fin;
            for (int i = parametros.Inicio; i <= parametros.Fin; i++) {
                progressBar1.Value = i;
            }
        }

        void Tarea2(object p)
        {
            Parametros parametros = p as Parametros;
            progressBar2.Minimum = parametros.Inicio;
            progressBar2.Maximum = parametros.Fin;
            for (int i = parametros.Inicio; i <= parametros.Fin; i++)
            {
                progressBar2.Value = i;
            }
        }

        void Tarea3(object p)
        {
            Parametros parametros = p as Parametros;
            progressBar3.Minimum = parametros.Inicio;
            progressBar3.Maximum = parametros.Fin;
            for (int i = parametros.Inicio; i <= parametros.Fin; i++)
            {
                progressBar3.Value = i;
            }
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                hilo1.Suspend();
            }
            catch (Exception)
            {
                MessageBox.Show("Hilo pausado");
                //throw;
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hilo1.Resume(); // Reiniciar
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hilo1.Abort(); // destruir

        }
    }
}

public class Parametros {
    public Int32 Inicio { get; set; }
    public Int32 Fin { get; set; }
}