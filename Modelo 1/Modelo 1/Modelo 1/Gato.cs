using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_1
{
    public class Gato : Mascota
    {
        /// <summary>
        /// CONSTRUCTOR BASE PARA INICIALIZAR EL NOMBRE Y LA RAZA DE UN GATO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="raza"></param>
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }

        /// <summary>
        /// METODO SOBREESCRITO QUE SE ENCARGA DE COMPARAR UN OBJETO CON OTRO 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE O FALSE</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Gato)
            {
                if((Mascota)this == (Mascota)obj)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// METODO QUE SE ENCARGA DE RETORNAR LOS DATOS COMPLETOS DE UN GATO
        /// </summary>
        /// <returns>STRING</returns>
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder("");

            sb.Append($"{this.GetType().Name} - {this.Nombre} - {this.Raza}");

            return sb.ToString();
        }

        /// <summary>
        /// SOBRECARGA QUE SE ENCARGA DE DE COMPARAR UN GATO CON OTRO (REUTILIZO CODIGO)
        /// </summary>
        /// <param name="g1"></param>
        /// <param name="g2"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator == (Gato g1, Gato g2)
        {
            bool retorno = false;
            if(g1 is not null && g2 is not null)
            {
                if((Mascota)g1 == (Mascota)g2)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// SOBRECARGA CONTRARIA A LA DE ARRIBA
        /// </summary>
        /// <param name="g1"></param>
        /// <param name="g2"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        /// <summary>
        /// METODO SOBREESCRITO QUE SE ENCARGA DE RETORNAR LOS DATOS QUE ME RETORNA EL METODO "FICHA()"
        /// </summary>
        /// <returns>STRING</returns>
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
