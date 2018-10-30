using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYK
{
    public partial class VentanaAlgoritmoCYK : Form
    {
        private VentanaProduccionesAgregadas ventanaProduccionesAgregadas;

        
        public VentanaAlgoritmoCYK(VentanaProduccionesAgregadas ventanaProduccionesAgregadas)
        {
            this.ventanaProduccionesAgregadas = ventanaProduccionesAgregadas;
            InitializeComponent();
        }

        //boton regresar
        private void button1_Click(object sender, EventArgs e)
        {
            ventanaProduccionesAgregadas.Visible = true;
            this.Visible=false;
        }
    }
}
