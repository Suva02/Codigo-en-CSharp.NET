using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_2
{
    public class Televisor : Producto
    {
        public ETipo tipo;

        public Televisor(string modelo, string marca, EPais pais, ETipo tipo) : base(modelo, marca, pais)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// RETORNA TRUE SI LOS PRODUCTOS Y LOS TIPOS SON IGUALES (REUTILIZO CODIGO)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator ==(Televisor a, Televisor b)
        {
            bool retorno = false;
            if((Producto)a == (Producto)b && a.tipo == b.tipo)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// RETORNA FALSE SI LOS TELEVISORES NO SON IGUALES
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }


        /// <summary>
        /// RETORNA EL PRECIO DEL TELEVISOR QUE RECIBE COMO PARAMETRO
        /// </summary>
        /// <param name="tv"></param>
        public static explicit operator double (Televisor tv)
        {
            return tv.Precio;
        }


        /// <summary>
        /// RETORNA TRUE SI EL OBJETO RECIBIDO ES IGUAL A EL OBJETO TELEVISOR
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE OR FALSE</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is not null)
            {
                if (obj is Televisor)
                {
                    if (this == (Televisor)obj)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }


        /// <summary>
        /// RETORNA LOS DATOS DEL TELEVISOR
        /// </summary>
        /// <returns>STRING</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            string datos = (string)(Producto)this;
            sb.Append(datos);
            sb.AppendLine($"TIPO: {this.tipo}");
            return sb.ToString();
        }
    }
}
