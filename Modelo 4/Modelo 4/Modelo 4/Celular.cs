using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_4
{
    public class Celular : Producto
    {
        int megaPixelesCamara;

        public Celular(string modelo, float precio, EMarca marca, int megaPixelesCamara) : base(modelo, precio, marca)
        {
            this.megaPixelesCamara = megaPixelesCamara;
        }


        /// <summary>
        /// DEVUELVE LA GARANTIA DEL CELULAR (SEGUN MARCA, PIXELES O NINGUNA DE LAS ANTERIORES)
        /// </summary>
        public override string Garantia
        {
            get
            {
                string retorno = "";
                if(this.marca == EMarca.Noblex || this.marca == EMarca.MarcaNoInformada)
                {
                    retorno = "Garantia de 12 meses";
                }
                else
                {
                    if(this.megaPixelesCamara > 12)
                    {
                        retorno = "Garantia de 36 meses";
                    }
                    else
                    {
                        retorno = "Garantia 24 meses";
                    }
                }
                return retorno;
            }
        }

        /// <summary>
        /// RETORNA EL PORCENTAJE DE DESCUENTO DEL CELULAR (5)
        /// </summary>
        protected override int PorcentajeDescuento
        {
            get
            {
                return 5;
            }
        }

        /// <summary>
        /// RETORNA LA INFORMACION DE UN CELULAR
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine(this.GetType().Name);
            sb.Append(base.ToString());
            sb.AppendLine($"Megapixeles: {this.megaPixelesCamara}");
            return sb.ToString();
        }
    }
}
