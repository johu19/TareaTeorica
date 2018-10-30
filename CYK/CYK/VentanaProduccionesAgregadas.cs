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
    public partial class VentanaProduccionesAgregadas : Form
    {
        public VentanaProduccionesAgregadas()
        {
            InitializeComponent();
        }
        private VentanaAlgoritmoCYK algoritmoCYK;
        private VentanaAgregarProducciones ventanaAgregarProduccion;
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            algoritmoCYK = new VentanaAlgoritmoCYK(this);
            algoritmoCYK.Visible = true;

        }

        private void btnAgregarProduccion_Click(object sender, EventArgs e)
        {
            
            ventanaAgregarProduccion = new VentanaAgregarProducciones(this);
            ventanaAgregarProduccion.Visible = true;
        }

        public void Gramatica gramatica;
    }
}
