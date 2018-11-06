using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK
{
    public class Gramatica
    {

        /*Atributos*/

         //Terminales
        private List<string> terminales;
         //Variables
        private List<Variable> variables;
         //Matriz resultante del algoritmo CYK
        private List<List<string>> matrizCYK;

        /*Constructor*/
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

        /*Getters & Setters*/
        public List<List<string>> getMatrizCYK()
        {
            return matrizCYK;
        }
        public List<string> Terminales { get => terminales; set => terminales = value; }
        public List<Variable> Variables { get => variables; set => variables = value; }

        /*Agrega una produccion. Parametros: variable, valor de la produccion*/
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

        /*Encuentra la variable respectiva de una cadena (string) pasada por parametro*/
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

        /*ALGORITMO CYK*/
        /*Realiza el algoritmo CYK con la gramatica ingresada.
         Retorna la matriz resultante del algoritmo.*/
        public List<List<string>> algoritmoCYK(string cadena)
        {
            List<List<string>> theMatrizCYK = new List<List<string>>();

            //valida que la cadena contenga solo terminales
            if (validarCadena(cadena) == true)
            {
                for(int i=0; i < cadena.Length; i++)
                {
                    theMatrizCYK.Add(new List<string>());
                }

                //agrega columna 1 en la matriz
                Char[] cad = cadena.ToCharArray();
                for(int j=0; j<cad.Length;j++)
                {
                    Char term = cad[j];
                     string v=buscarVariablesPorCadena(term);
                    theMatrizCYK.ElementAt(j).Add( v);

                }

                int n = cadena.Length;

                //agrega siguientes columnas en la matriz
                for (int j = 1; j < cadena.Length; j++)
                {
                    int topeFila = n - j;

                    for (int i = 0; i < topeFila; i++)
                    {

                        int topeK = j;

                        string concatenacion = "";

                        for (int k = 1; k <= topeK; k++)
                        {
                            string s1 = theMatrizCYK.ElementAt(i).ElementAt(k-1);
                            string s2 = theMatrizCYK.ElementAt(i + k).ElementAt(j - k);

                            string conqui= concatenar(s1, s2);

                            if (concatenacion.Equals(""))
                            {
                                concatenacion += conqui;
                            }
                            else
                            {
                                concatenacion += "," + conqui;
                            }
                            
                        }

                        string concaFinal = "";

                        if (concatenacion.Length > 1)
                        {
                            string[] products = concatenacion.Split(',');
                            
                            foreach(string pActual in products)
                            {
                               string vari= buscarVariablesPorCadenaString(pActual);
                                if (concaFinal.Equals(""))
                                {
                                    concaFinal+= vari;
                                }
                                
                                else if( !vari.Equals(""))
                                {
                                    concaFinal+= "," + vari;
                                }
                            }

                            
                        }
                        else
                        {
                            concaFinal = buscarVariablesPorCadenaString(concatenacion);

                        }

                        string[] finito = concaFinal.Split(',');
                        
                        for(int m = 0; m < finito.Length; m++)
                        {
                            Boolean cond = false;
                            for (int p = m; p < finito.Length && !cond; p++)
                            {
                                if (p != m)
                                {
                                    if (finito[m].Equals(finito[p]))
                                    {
                                        cond = true;
                                        finito[m] = null;
                                    }
                                }
                            }
                        }
                        concaFinal = "";
                        foreach(string s in finito)
                        {
                            if (s != null)
                            {
                                if (concaFinal.Equals("")) {
                                    concaFinal += s;
                                }
                                else
                                {
                                    concaFinal += "," + s;
                                }
                            }
                        }

                        theMatrizCYK.ElementAt(i).Add(concaFinal);


                    }
                }


                matrizCYK = theMatrizCYK;
                



            }

            return matrizCYK;

        }

        /*Concatena 2 strings que representan conjuntos encontrados por el CYK
         dependiendo de la longitud de cada uno, si uno es mayor al otro y mayor a 1,
         concatena el conjunto s1(izquierda) con el conjunto s2(derecha)
         de manera diferente (segun su longitud y quien sea mayor)*/
        public string concatenar(string s1, string s2)
        {
            string conqui = "";
            if(s1.Length==1 && s2.Length == 1)
            {
                conqui = s1 + s2;
            }
            else if (s1.Length == s2.Length)
            {
                string[] mayor = s2.Split(',');

                if (s1.Length == 1)
                {

                    foreach (string c in mayor)
                    {
                        if (conqui.Equals(""))
                        {
                            conqui += s1 + c;
                        }
                        else
                        {
                            conqui += "," + s1 + c;
                        }
                    }
                }
                else
                {
                    string[] menor = s1.Split(',');

                    foreach (string menorAct in menor)
                    {
                        foreach (string mayorAct in mayor)
                        {
                            if (conqui.Equals(""))
                            {
                                conqui += menorAct + mayorAct;
                            }
                            else
                            {
                                conqui += "," + menorAct + mayorAct;
                            }

                        }
                    }

                }
            }
            else if (s1.Length<s2.Length)
            {
                string[] mayor = s2.Split(',');

                if (s1.Length == 1)
                {
                   
                    foreach (string c in mayor)
                    {
                        if (conqui.Equals(""))
                        {
                            conqui += s1 + c;
                        }
                        else
                        {
                            conqui += "," + s1 + c;
                        }
                    }
                }
                else
                {
                    string[] menor = s1.Split(',');

                    foreach(string menorAct in menor)
                    {
                        foreach(string mayorAct in mayor)
                        {
                            if (conqui.Equals(""))
                            {
                                conqui += menorAct +mayorAct ;
                            }
                            else
                            {
                                conqui += "," + menorAct + mayorAct;
                            }

                        }
                    }

                }
                
            }else if (s1.Length > s2.Length)
            {
                string[] mayor = s1.Split(',');

                if (s2.Length == 1)
                {
                    
                    foreach (string c in mayor)
                    {
                        if (conqui.Equals(""))
                        {
                            conqui +=c+ s2 ;
                        }
                        else
                        {
                            conqui += "," +c+ s2;
                        }
                    }
                }
                else
                {
                    string[] menor = s2.Split(',');

                    foreach (string menorAct in menor)
                    {
                        foreach (string mayorAct in mayor)
                        {
                            if (conqui.Equals(""))
                            {
                                conqui += mayorAct+ menorAct ;
                            }
                            else
                            {
                                conqui += "," + mayorAct + menorAct ;
                            }

                        }
                    }
                }

            }


            return conqui;
        }


        /*Valida que la cadena w ingresada tenga caracteres validos,
         es decir, que pertenezcan a los terminales ingresados
         anteriormente*/
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

        /*Busca la variable a la que correspondria un valor pasado por parametro.
         Es decir si las producciones de una variable contienen al terminal term entonces
         el metodo retorna la variable encontrada, sino retorna vacío.
         (1er paso del CYK, para encontrar producciones a las q pertenece los terminos de la cadena w.)*/
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

        /*Busca la variable a la que correspondria un valor pasado por parametro.
         Es decir si las producciones de una variable contienen a la cadena term entonces
         el metodo retorna la variable encontrada, sino retorna vacío.
         (metodo utilizado para encontrar conjuntos en el cyk y llenar asi la matriz.)*/
        public string buscarVariablesPorCadenaString(string term)
        {
            string var = "";

            foreach (Variable actual in variables)
            {
                foreach (Produccion product in actual.Producciones)
                {
                    if (product.valor.Equals(term))
                    {
                        if (var.Equals(""))
                        {
                            var += actual.valor;
                        }
                        else
                        {
                            var = var + "," + actual.valor;
                        }

                    }
                }
            }

            return var;
        }


    }
}
