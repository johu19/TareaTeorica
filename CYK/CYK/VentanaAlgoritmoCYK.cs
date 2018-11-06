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
       
        private Gramatica gramatica;
        private Interfaz interfaz;

        public VentanaAlgoritmoCYK(Interfaz inter, Gramatica grama)
        {
            InitializeComponent();
            interfaz = inter;
            gramatica = grama;
            inicializarComboBox();
        }

        //boton regresar
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Visible=false;
        }

        public void mostrarGramatica()
        {
            
            
            tablaProducciones.Items.Clear();
            foreach (Variable variable in gramatica.Variables)
            {
                ListViewItem lista = new ListViewItem(variable.valor);
                //lista.SubItems.Add();
                lista.SubItems.Add("--->");
                string produc = "";
                foreach(Produccion produccion in variable.Producciones)
                {
                    produc += produccion.valor + " | ";
                }
                lista.SubItems.Add(produc);
                tablaProducciones.Items.Add(lista);
            }
            
           
        }

        private void VentanaAlgoritmoCYK_Load(object sender, EventArgs e)
        {

        }

        private void inicializarComboBox()
        {
            foreach (Variable variable in gramatica.Variables)
            {
                comboBoxVariables.Items.Add(variable.valor);
            }
        }

        private void btnAgregarProduccion_Click(object sender, EventArgs e)
        {
            if (txtValorProduccion.Text != null)
            {
                if (comboBoxVariables.Text != null)
                {
                    //validar que los strings  valores esten en las listas guardadas

                    Variable variable = gramatica.BuscarVariable(comboBoxVariables.Text);

                    if (variable.agregarProduccion(txtValorProduccion.Text) == false)
                    {
                        MessageBox.Show("Error, debe ingresar una producción que siga la forma normal" +
                            "de Chomsky.");
                    }
                    else
                    {
                        //MessageBox.Show("Se ha agregado correctamente la producción : " +
                        //    comboBoxVariables.Text + "--->" + txtValorProduccion.Text);
                        mostrarGramatica();

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

        private void btnValidarConCYK_Click(object sender, EventArgs e)
        {
            if (!txtCadena.Text.Equals(""))
            {
                gramatica.algoritmoCYK(txtCadena.Text);

                string cadena = txtCadena.Text;

                List<List<string>> matriz = gramatica.getMatrizCYK();

                if (matriz.ElementAt(0).Last().Split(',').Contains("S"))
                {
                    lblResultado.Text = "La gramática G SÍ acepta a la cadena w. ";

                }
                else
                {
                    lblResultado.Text = "La gramática G NO acepta a la cadena w. ";
                }

                tablaCYK.Columns.Clear();
                tablaCYK.Rows.Clear();

                for(int j = 0; j < cadena.Length; j++)
                {
                    tablaCYK.Columns.Add(new DataGridViewTextBoxColumn());
                    
                }

                for(int i = 0; i < cadena.Length; i++)
                {
                    tablaCYK.Rows.Add();
                }

                for(int j = 0; j < cadena.Length; j++)
                {
                    int tamanio = matriz.ElementAt(j).Count;

                    if (matriz.First().Count > j)
                    {
                        for (int i = 0; i < tamanio; i++)
                        {

                            string s = matriz.ElementAt(j).ElementAt(i);
                            tablaCYK.Rows[j].Cells[i].Value = "{"+s+"}";

                        }
                    }
                    
                }




            }
        }
    }
}
