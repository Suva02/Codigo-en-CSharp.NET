using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_2
{
    public class Celular : Producto
    {
        EGama gama;

        public Celular(string modelo, Fabricante fabricante, EGama gama) : base(modelo, fabricante)
        {
            this.gama = gama;
        }


        /// <summary>
        /// RETORNA TRUE SI LOS PRODUCTOS Y LAS GAMAS SON IGUALES (REUTILIZO CODIGO)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator == (Celular a, Celular b)
        {
            bool retorno = false;
            if ((Producto)a == (Producto)b && a.gama == b.gama)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// RETORNA FALSE SI LOS CELULARES NO SON IGUALES
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        /// <summary>
        /// RETORNA TRUE SI EL OBJETO RECIBIDO ES IGUAL A EL OBJETO CELULAR
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE O FALSE</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is not null)
            {
                if(obj is Celular)
                {
                    if(this == (Celular)obj)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }


        /// <summary>
        /// RETORNA EL PRECIO DEL CELULAR QUE RECIBE COMO PARAMETRO
        /// </summary>
        /// <param name="celu"></param>
        public static implicit operator double (Celular celu)
        {
            return celu.Precio;
        }



        /// <summary>
        /// RETORNA LOS DATOS COMPLETOS DE UN CELULAR
        /// </summary>
        /// <returns>STRING</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            string datos = (string)(Producto)this;
            sb.Append(datos);
            sb.AppendLine($"GAMA: {this.gama}");
            return sb.ToString();
        }
    }
}
