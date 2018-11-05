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

        public Gramatica(List<string> var, List<string> term)
        {
            Variables = new List<Variable>();
            foreach(string s in var)
            {
                Variable v = new Variable(s);
                Variables.Add(v);
            }
            Terminales = term;
        }

        
        public List<string> Terminales { get => terminales; set => terminales = value; }
        public List<Variable> Variables { get => variables; set => variables = value; }

        public Boolean agregarProduccion(string var,string prod)
        {
            Boolean cond = true;
            char[] letras = prod.ToCharArray();
            foreach (char c in letras)
            {
                string s = c + "";
                if(Variables.Any(v=>v.valor.Equals(s))||Terminales.Any(t=> t.Equals(s)))
                {
                    cond = false;
                }
            }

            if(cond == false)
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
            
                for(int i=0; i<Variables.Count && encontro==false; i++)
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

        
    }
}
