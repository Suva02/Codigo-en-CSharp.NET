using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_1
{
    public class Perro : Mascota
    {
        int edad;
        bool esAlfa;

        /// <summary>
        /// CONSTRUCTOR BASE PARA INICIALIZAR NOMBRE Y RAZA DEL PERRO MAS LOS ATRIBUTOS AGREGADOS (EDAD Y ESALFA)
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="raza"></param>
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }
        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR PARA INICIALIZAR EDAD Y ESALFA CON LO QUE SE PASA COMO PARAMETRO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="raza"></param>
        /// <param name="edad"></param>
        /// <param name="esAlfa"></param>
        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        /// <summary>
        /// SOBREESCRITURA DEL METODO EQUALS PARA COMPARAR EL OBJETO CON LO QUE SE PASA COMO PARAMETRO
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE O FALSE</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Perro)
            {
                if ((Mascota)this == (Mascota)obj)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// SOBRECARGA DE CONVERSION IMPLICITA QUE RETORNA LA EDAD DE UN PERRO
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator int (Perro p)
        {
            return p.edad;
        }

        /// <summary>
        /// METODO PROTEGIDO QUE RETORNA LOS DATOS COMPLETOS DE UN PERRO
        /// </summary>
        /// <returns></returns>
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder("");
            int edad = this;
            if(this.esAlfa == true)
            {
                sb.Append($"{this.GetType().Name} - {this.Nombre} - {this.Raza}, alfa de la manada, edad {edad}");
            }
            else
            {
                sb.Append($"{this.GetType().Name} - {this.Nombre} - {this.Raza},edad {edad}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// SOBRECARGA QUE COMPARA UN PERRO CON OTRO (REUTILIZO CODIGO)
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Perro p1, Perro p2)
        {
            bool retorno = false;
            if(p1 is not null && p2 is not null)
            {
                if((Mascota)p1 == (Mascota)p2)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// SOBRECARGA CONTRARIA A LA DE ARRIBA
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// METODO SOBREESCRITO QUE RETORNA LOS DATOS QUE ME RETORNA EL METODO "FICHA()"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
