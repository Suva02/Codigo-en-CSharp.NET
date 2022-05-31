using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_4
{
    public class Televisor : Producto
    {
        bool esSmart;

        public Televisor(string modelo, int precio, bool esSmart) : base (modelo, precio)
        {
            this.esSmart = esSmart;
        }

        public Televisor(string modelo, int precio, EMarca marca, bool esSmart) : base(modelo,precio,marca)
        {
            this.esSmart = esSmart;
        }

        /// <summary>
        /// RETORNA LA GARANTIA DE UN TELEVISOR (DEPENDIENDO SI ES SMART O NO)
        /// </summary>
        public override string Garantia
        {
            get
            {
                string retorno = "";
                if(this.esSmart == true)
                {
                    retorno = "Garantia de 48 meses";
                }
                else
                {
                    retorno = "Garantia de 36 meses";
                }
                return retorno;
            }
        }

        protected override int PorcentajeDescuento
        {
            get
            {
                return 10;
            }
        }

        /// <summary>
        /// RETORNA LA INFORMACION DE UN TELEVISOR
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            if(this.esSmart == true)
            {
                sb.AppendLine($"Televisor Smart TV");
            }
            else
            {
                sb.AppendLine($"Televisor Led");
            }
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
