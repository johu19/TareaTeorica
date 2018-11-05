using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK
{
    public class Gramatica
    {
        private List<string> terminales;
        private List<Variable> variables;

        private List<List<string>> matrizCYK;


        public Gramatica(List<string> var, List<string> term)
        {
            Variables = new List<Variable>();
            foreach (string s in var)
            {
                Variable v = new Variable(s);
                Variables.Add(v);
            }
            Terminales = term;
        }


        public List<string> Terminales { get => terminales; set => terminales = value; }
        public List<Variable> Variables { get => variables; set => variables = value; }

        public Boolean agregarProduccion(string var, string prod)
        {
            Boolean cond = true;
            char[] letras = prod.ToCharArray();
            foreach (char c in letras)
            {
                string s = c + "";
                if (Variables.Any(v => v.valor.Equals(s)) || Terminales.Any(t => t.Equals(s)))
                {
                    cond = false;
                }
            }

            if (cond == false)
            {
                return cond;
            }
            else
            {
                return Variables.Where(v => v.valor.Equals(var)).First().agregarProduccion(prod);
            }

        }

        public Variable BuscarVariable(string var)
        {
            Variable variable = null;
            Boolean encontro = false;

            for (int i = 0; i < Variables.Count && encontro == false; i++)
            {
                Variable actual = Variables[i];

                if (actual.valor.Equals(var))
                {
                    variable = actual;
                    encontro = true;
                }
            }

            return variable;
        }


        //TODO
        //Retorna la matriz resultante del algorimo CYK
        public List<List<string>> algoritmoCYK(string cadena)
        {
            matrizCYK = new List<List<string>>();

            //validar que la cadena contenga terminales
            if (validarCadena(cadena) == true)
            {

                //agregar columna 1 en la matriz

                Char[] cad = cadena.ToCharArray();
                for(int j=0; j<cad.Length;j++)
                {
                    Char term = cad[j];
                     string v=buscarVariablesPorCadena(term);
                    matrizCYK[0][j] = "{" + v + "}";

                }
                
                //agregar siguientes columnas
                for(int j=0; j < cadena.Length - 1; j++)
                {

                    for(int i=0; i< cadena.Length - 1; i++)
                    {
                        //TODO
                    }
                }
                



            }

            return matrizCYK;

        }

        public Boolean validarCadena(string cadena)
        {
            bool encontrada = false;

            Char[] cad = cadena.ToCharArray();
            for(int i=0; i < cad.Length ; i++)
            {
                encontrada = false;
                foreach(string term in terminales)
                {
                    if (cad[i].Equals(term.ToString()))
                    {
                        encontrada = true;
                    }
                }
            }

            return encontrada;

        }

        public string buscarVariablesPorCadena(char term)
        {
            string var = "";

            foreach(Variable actual in variables)
            {
                foreach(Produccion product in actual.Producciones)
                {
                    if (product.valor.Equals(term.ToString()))
                    {
                        var += actual.valor + ",";
                    }
                }
            }

            return var;
        }

        
    }
}
