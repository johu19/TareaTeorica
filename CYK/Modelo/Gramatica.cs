using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Gramatica
    {

        private List<Variable> variables;
        private string[][] matriz;


        public List<Variable> GetVariables()
        {
            return variables;
        }


        public void SetVariables(List<Variable> var)
        {
            variables = var;
        }

        public string[][] GetMatriz()
        {
            return matriz;
        }

        public void SetMatriz(string[][] m)
        {
            matriz = m;
        }


        public Gramatica(List<string> varia)
        {
            foreach(string v in varia)
            {

            }
        }
        


    }
}
