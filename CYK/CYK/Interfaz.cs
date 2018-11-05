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
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private Gramatica gramatica;

        private VentanaAlgoritmoCYK ventanaCyk;

       

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string[] var = textVariables.Text.Split(',');
            string[] term = textTerminales.Text.Split(',');

            List<string> variables = new List<string>();
            foreach(string s in var)
            {
                variables.Add(s);
            }

            List<string> terminales = new List<string>();
            foreach (string s in term)
            {
                terminales.Add(s);
            }

            gramatica = new Gramatica(variables, terminales);

            ventanaCyk = new VentanaAlgoritmoCYK(this,gramatica);
            ventanaCyk.Visible = true;
            this.Visible = false;
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            textVariables.Text = "S,";
            textTerminales.Text = "";
        }
    }
}
