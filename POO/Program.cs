﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Application.Run(new Colecciones.frmListas());
            //Application.Run(new Aplicaciones.frmPagos());
            //Application.Run(new Hilos.frmHilos());
            //Application.Run(new Temporizador.frmRelog());
        }
    }
}
