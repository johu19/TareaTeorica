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

        public List<List<string>> getMatrizCYK()
        {
            return matrizCYK;
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
            List<List<string>> theMatrizCYK = new List<List<string>>();

            //validar que la cadena contenga terminales
            if (validarCadena(cadena) == true)
            {
                for(int i=0; i < cadena.Length; i++)
                {
                    theMatrizCYK.Add(new List<string>());
                }

                //agregar columna 1 en la matriz

                Char[] cad = cadena.ToCharArray();
                for(int j=0; j<cad.Length;j++)
                {
                    Char term = cad[j];
                     string v=buscarVariablesPorCadena(term);
                    theMatrizCYK.ElementAt(j).Add("{" + v + "}");

                }

                //int n = cadena.Length;
                
                ////agregar siguientes columnas
                //for(int j=1; j < cadena.Length; j++)
                //{
                //    int topeFila = n - j;

                //    for(int i=0; i< topeFila; i++)
                //    {

                //        int topeK = j+1;



                //        //AQUI TODO


                //        for(int k=1; k < topeK; k++)
                //        {
                //            string s1 = theMatrizCYK.ElementAt(i).ElementAt(j);
                //            string s2 = theMatrizCYK.ElementAt(i + k).ElementAt(j - k);



                //        }


                //    }
                //}


                matrizCYK = theMatrizCYK;
                



            }

            return matrizCYK;

        }

        public Boolean validarCadena(string cadena)
        {
            bool encontrada = true;

            Char[] cad = cadena.ToCharArray();
            for(int i=0; i < cad.Length && encontrada ; i++)
            {
                encontrada = false;
                string s = cad[i] + "";
                foreach(string term in terminales)
                {
                    if (s.Equals(term))
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
                        if (var.Equals(""))
                        {
                            var += actual.valor;
                        }
                        else
                        {
                            var =var+ ","+actual.valor;
                        }
                        
                    }
                }
            }

            return var;
        }

        
    }
}
