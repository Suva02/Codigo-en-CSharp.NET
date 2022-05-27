using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_3
{
    public static class Marvel
    {
        static List<Personaje> listaPersonajes;

        static Marvel()
        {
            Marvel.listaPersonajes = new List<Personaje>();
        }

        /// <summary>
        /// PROPIEDAD ESTATICA QUE AGREGA UN PERSONAJE A LA LISTA
        /// </summary>
        public static Personaje Personaje
        {
            set
            {
                if(Marvel.listaPersonajes != value)
                {
                    Marvel.listaPersonajes = Marvel.listaPersonajes + value;
                }
            }
        }
        
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder("");
            foreach (Personaje item in Marvel.listaPersonajes)
            {
                if(item is Avenger)
                {
                    sb.AppendLine("\n******AVENGER******");
                    sb.AppendLine(((Avenger)item).ToString());
                }
                else
                {
                    if (item is Enemigo)
                    {
                        sb.AppendLine("\n******ENEMIGO******");
                        sb.AppendLine(((Enemigo)item).ToString());
                    }
                }
            }

            return sb.ToString();
        }
    }
}
