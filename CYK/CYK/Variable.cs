using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYK
{

    

    public class Variable
    {

        public string valor { get; set; }
        public List<Produccion> Producciones { get => producciones; set => producciones = value; }

        private List<Produccion> producciones;


        public Variable(string v)
        {
            producciones = new List<Produccion>();
            valor = v;

        }

        //verificar lo de las variables inutiles
        public Boolean agregarProduccion(string nom)
        {
            if (nom.Length > 2)
            {
                return false;
            }
            else
            {
                if (nom.ToCharArray().ElementAt(0).Equals(valor))
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
