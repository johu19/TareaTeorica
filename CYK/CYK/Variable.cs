using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK
{

    
    
    public class Variable
    {
        /*Atributos*/
        public string valor { get; set; }
        public List<Produccion> Producciones { get => producciones; set => producciones = value; }
        private List<Produccion> producciones;

        /*Constructor*/
        public Variable(string v)
        {
            producciones = new List<Produccion>();
            valor = v;

        }

        /*Agrega una produccion a su lista de producciones*/
        public Boolean agregarProduccion(string nom)
        {
            if (nom.Length > 2)
            {
                return false;
            }
            else
            {
                string s = nom.ToCharArray().First() + "";
                if (s.Equals(valor))
                {
                    return false;
                }
                else
                {
                    //string s = nom.ToCharArray().First() + "";
                    //if (Encoding.ASCII.GetBytes(s)[0] >= 65 && Encoding.ASCII.GetBytes(s)[0]<=90)
                    //{
                    //    return false;
                    //}
                    //else
                    //{
                        Produccion p = new Produccion(nom);
                        producciones.Add(p);
                        return true;
                    //}

                     
                }

            }


            
        }

    }
}
