using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK
{
    class Gramatica
    {
        public List<Variable> variables { get; set; }
        public List<string> terminales { get; set; }

        public Gramatica(List<string> var, List<string> term)
        {
            variables = new List<Variable>();
            foreach(string s in var)
            {
                Variable v = new Variable(s);
                variables.Add(v);
            }
            terminales = term;
        }

        public Boolean agregarProduccion(string var,string prod)
        {
            Boolean cond = true;
            char[] letras = prod.ToCharArray();
            foreach (char c in letras)
            {
                string s = c + "";
                if(variables.Any(v=>v.valor.Equals(s))||terminales.Any(t=> t.Equals(s)))
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
                return variables.Where(v => v.valor.Equals(var)).First().agregarProduccion(prod);
            }
            
        }
    }
}
