using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_4
{
    public abstract class Producto
    {
        protected EMarca marca;
        protected string modelo;
        protected float precio;


        private Producto()
        {
            this.marca = EMarca.MarcaNoInformada;
        }
        public Producto(string modelo, float precio) : this()
        {
            this.modelo = modelo;
            this.precio = precio;
        }
        public Producto(string modelo, float precio, EMarca marca) : this(modelo, precio)
        {
            this.marca = marca;
        }


        public abstract string Garantia { get; }
        protected abstract int PorcentajeDescuento { get; }

        public void AplicarDescuento()
        {
            float calculoUno;
            float calculoDos;
            float PrecioConDescuento;
            calculoUno = this.PorcentajeDescuento * this.precio;
            calculoDos = calculoUno / 100;
            PrecioConDescuento = this.precio - calculoDos;
            this.precio = PrecioConDescuento;
        }

        /// <summary>
        /// RETORNA TRUE SI DOS PRODUCTOS SON IGUALES (POR MARCA, MODELO Y TIPO DE PRODUCTO)
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Producto p1, Producto p2)
        {
            bool retorno = false;
            if(p1.marca == p2.marca && p1.modelo == p2.modelo && p1.GetType() == p2.GetType())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// RETORNA FALSE SI DOS PRODUCTOS NO SON IGUALES
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// RECORRE LA LISTA Y SE FIJA SI EL PRODUCTO PASADO COMO PARAMETRO YA ESTA EN LA LISTA
        /// </summary>
        /// <param name="listaProd"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator == (List<Producto> listaProd, Producto p1)
        {
            bool retorno = false;
            foreach (Producto item in listaProd)
            {
                if(item == p1)              
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }


        /// <summary>
        /// RETORNA FALSE SI EL PRODUCTO NO SE ENCUENTRA EN LA LISTA
        /// </summary>
        /// <param name="listaProd"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator !=(List<Producto> listaProd, Producto p1)
        {
            return !(listaProd == p1);
        }


        /// <summary>
        /// AGREGA UN PRODUCTO A LA LISTA SI ESTE NO SE ENCUENTRA EN ELLA
        /// </summary>
        /// <param name="listaProd"></param>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool operator +(List<Producto> listaProd, Producto p1)
        {
            bool retorno = false;
            if(listaProd != p1)
            {
                listaProd.Add(p1);
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// DEVUELVE LA INFORMACION DE UN PRODUCTO (MODELO, PRECIO, MARCA, GARANTIA)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Precio: {this.precio}");      
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Garantia: {this.Garantia}");
            return sb.ToString();
        }


    }
}
