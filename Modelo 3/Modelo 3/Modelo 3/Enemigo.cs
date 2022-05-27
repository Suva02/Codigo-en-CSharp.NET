using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_3
{
    public class Enemigo : Personaje
    {
        string objetivo;

        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo) : base(hab, nombre)
        {
            this.objetivo = objetivo;
        }


        /// <summary>
        /// PROPIEDAD QUE ME RETORNA EL NOMBRE DEL ENEMIGO
        /// </summary>
        protected override string Nombre
        {
            get
            {
                return $"Soy {this.nombre} y los voy a hacer pure";
            }
        }


        /// <summary>
        /// ME RETORNA TODOS LOS DATOS DE UN ENEMIGO
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine(base.ToString());
            sb.AppendLine("Objetivo: ");
            sb.AppendLine(this.objetivo);
            return sb.ToString();
        }

    }
}
