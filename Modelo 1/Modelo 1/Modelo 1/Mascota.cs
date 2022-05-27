using System;
using System.Text;

namespace Modelo_1
{
    public abstract class Mascota
    {
        string nombre;
        string raza;

        /// <summary>
        /// CONSTRUCTOR PROTEGIDO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="raza"></param>
        protected Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        /// <summary>
        /// PROPIEDAD QUE RETORNA EL NOMBRE DE LA MASCOTA
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// PROPIEDAD QUE RETORNA LA RAZA DE LA MASCOTA
        /// </summary>
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        /// <summary>
        /// METODO PROTEGIDO QUE RETORNA LOS DATOS COMPLETOS DE UNA MASCOTA
        /// </summary>
        /// <returns>STRING</returns>
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine($"{this.Nombre} - {this.Raza}");

            return sb.ToString();
        }

        /// <summary>
        /// METODO ABSTRACTO Y PROTEGIDO A IMPLEMENTAR
        /// </summary>
        /// <returns></returns>
        protected abstract string Ficha();

        /// <summary>
        /// SOBRECARGA QUE DEVUELVE "TRUE" SI DOS MASCOTAS SON IGUALES
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator == (Mascota m1, Mascota m2)
        {
            bool retorno = false;
            if(m1 is not null && m2 is not null)
            {
                if(m1.Nombre == m2.Nombre && m2.Raza == m2.Raza)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// SOBRECARGA CONTRARIA QUE DEVUELVE FALSE SI DOS MASCOTAS SON DISTINTAS
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }


    }
}
