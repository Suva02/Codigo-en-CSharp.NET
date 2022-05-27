using System;

namespace Modelo_2
{
    public class Fabricante
    {
        string marca;
        EPais pais;

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        /// <summary>
        /// RETORNA TRUE SI LOS FABRICANTES SON IGUALES (MISMA MARCA, MISMO PAIS)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator == (Fabricante a, Fabricante b)
        {
            bool retorno = false;
            if(a.pais == b.pais && a.marca == b.marca)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// RETORNA FALSE SI LOS FABRICANTES NO SON IGUALES
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

        /// <summary>
        /// RETORNA LA MARCA Y EL PAIS DE UN FABRICANTE
        /// </summary>
        /// <param name="f"></param>
        public static implicit operator string(Fabricante f)
        {
            string datos = f.marca + " - " + f.pais;
            return datos;
        }
    }
}
