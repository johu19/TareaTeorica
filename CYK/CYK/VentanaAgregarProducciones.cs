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
    public partial class VentanaAgregarProducciones : Form
    {
        private VentanaProduccionesAgregadas ventanaProduccionesAgregadas;
        private Gramatica gramatica;
        

        public VentanaAgregarProducciones(VentanaProduccionesAgregadas ventanaProduccionesAgregadas, Gramatica grama)
        {
            InitializeComponent();
            this.ventanaProduccionesAgregadas = ventanaProduccionesAgregadas;
            inicializarComboBox();
            gramatica = grama;

        }

        private void inicializarComboBox()
        {
            
        }

        public void btnAgregarProduccion_Click(object sender, EventArgs e)
        {
            

                foreach (Variable es in gramatica.)
            {
                comboBoxVariables.Items.Add(es.getValor());
                
            }
        }
    }
}
