using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK
{
   public class Produccion
    {
        //Una variable va a tener varias producciones, cada produccion tiene un valor
        //(lado derecho de las producciones)

     
        public string valor { get; set; }

        public Produccion(string v)
        {
            valor = v;
        }


    }
}
