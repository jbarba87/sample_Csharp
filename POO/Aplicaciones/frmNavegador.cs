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
    public partial class frmNavegador : Form
    {
        public frmNavegador()
        {
            InitializeComponent();
        }

        private void frmNavegador_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://elcomercio.pe");
        }
    }
}
