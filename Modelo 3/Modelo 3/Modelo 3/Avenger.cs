using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_3
{
    public class Avenger : Personaje
    {
        EEquipamiento equipamento;
        public Avenger(List<EHabilidades> listaHabilidades, string nombre, EEquipamiento equipo) : base(listaHabilidades, nombre)
        {
            this.equipamento = equipo;
        }


        /// <summary>
        /// ME RETORNA EL NOMBRE DEL AVENGER
        /// </summary>
        protected override string Nombre
        {
            get
            {
                return $"Mi nombre es {this.nombre} y si no puedo proteger la tierra la vengare";
            }
        }


        /// <summary>
        /// ME RETORNA LOS DATOS DE UN AVENGER
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Equipamento principal: {this.equipamento}");
            return sb.ToString();
        }


    }
}
