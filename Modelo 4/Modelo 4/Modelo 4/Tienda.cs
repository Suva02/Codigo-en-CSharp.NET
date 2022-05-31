using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_4
{
    public static class Tienda
    {
        const int capacidadTienda = 10;
        static Random rnd;
        static List<Producto> stockTienda;

        static Tienda()
        {
            Tienda.stockTienda = new List<Producto>();
            Tienda.rnd = new Random();
        }

        /// <summary>
        /// RETORNA EL NOMBRE DE LA TIENDA
        /// </summary>
        public static string NombreTienda
        {
            get
            {
                return "Electrodomesticos Pepe Peposo";
            }
        }

        /// <summary>
        /// RETORNA UN PRODUCTO DE LA TIENDA DE FORMA ALEATORIA
        /// </summary>
        public static Producto Oferta
        {
            get
            {
                Producto prod = null;
                int indiceRnd = Tienda.rnd.Next(0, Tienda.capacidadTienda);
                prod = Tienda.stockTienda[indiceRnd];
                prod.AplicarDescuento();
                return prod;
            }
        }

        /// <summary>
        /// AGREGA UN PRODUCTO A LA TIENDA
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool AgregarProducto(Producto prod)
        {
            bool retorno = false;
            if(Tienda.stockTienda.Count < Tienda.capacidadTienda)
            {
                if(!(Tienda.stockTienda.Contains(prod)))
                {
                    Tienda.stockTienda.Add(prod);
                    retorno = true;
                }
            }

            return retorno;
        }


        /// <summary>
        /// DEVUELVE TODA LA INFO DE LA TIENDA MAS TODA LA INFO DE LOS PRODUCTOS
        /// </summary>
        /// <returns></returns>
        public static string InfoTienda()
        {
            StringBuilder sb = new StringBuilder("");
            foreach (Producto item in Tienda.stockTienda)
            {
                if(item is Celular)
                {
                    sb.AppendLine(((Celular)item).ToString());
                }
                else
                {
                    if(item is Televisor)
                    {
                        sb.AppendLine(((Televisor)item).ToString());
                    }
                }
            }

            return sb.ToString();
        }
    }
}
