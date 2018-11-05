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

        private Gramatica gramatica;
        

        public VentanaAgregarProducciones( Gramatica grama)
        {
            InitializeComponent();

            gramatica = grama;
            inicializarComboBox();
            

        }

        private void inicializarComboBox()
        {
            foreach (Variable variable in gramatica.Variables)
            {
                comboBoxVariables.Items.Add(variable.valor);
            }
        }

        public void btnAgregarProduccion_Click(object sender, EventArgs e)
        {


            if (txtValorProduccion.Text != null)
            {
                if (comboBoxVariables.Text != null)
                {
                    //validar que los strings  valores esten en las listas guardadas

                    Variable variable = gramatica.BuscarVariable(comboBoxVariables.Text);

                    if (variable.agregarProduccion(txtValorProduccion.Text)==false)
                    {
                        MessageBox.Show("Error, debe ingresar una producción que siga la forma normal" +
                            "de Chomsky.");
                    }
                    else
                    {
                        MessageBox.Show("Se ha agregado correctamente la producción : "+
                            comboBoxVariables.Text +"--->"+txtValorProduccion.Text);
                        

                        this.Visible = false;

                    };
                }
                else
                {
                    MessageBox.Show("Error, debe ingresar el valor de la producción.");
                }
            }
            else
            {
                MessageBox.Show("Error, debe seleccionar una variable.");
            }


        }
    }
}
