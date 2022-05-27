using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_2
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected double precio;

        static Producto()
        {
            Producto.generadorDePrecios = new Random();
        }

        public Producto(string modelo, Fabricante fabricante)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
        }

        public Producto(string modelo, string marca, EPais pais) : this(modelo, new Fabricante(marca,pais))
        {

        }


        /// <summary>
        /// PROPIEDAD QUE ME RETORNA EL PRECIO CALCULADO CON EL ATRIBUTO GENERADOR DE PRECIOS (RANDOM)
        /// </summary>
        public double Precio
        {
            get
            {
                if (this.precio == 0)
                {
                    this.precio = Producto.generadorDePrecios.Next(10500, 125000);
                }
                return this.precio;
            }
        }

        /// <summary>
        /// REUTILIZO EL CODIGO DE LA SOBRECARGA DE CONVERSION PARA RETORNAR LOS DATOS DE UN 
        /// PRODUCTO
        /// </summary>
        /// <param name="p"></param>
        /// <returns>STRING</returns>
        private static string Mostrar(Producto p)
        {
            string datos = (string)p;
            return datos;
        }

        /// <summary>
        /// RETORNA LOS DATOS COMPLETOS DE UN PRODUCTO
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder("");
            string datos = p.fabricante;
            sb.AppendLine($"FABRICANTE: {datos}");
            sb.AppendLine($"MODELO: {p.modelo}");
            sb.AppendLine($"PRECIO: {p.Precio}");
            return sb.ToString();
        }

        /// <summary>
        /// RETORNA TRUE SI LOS MODELOS Y LOS FABRICANTES SON IGUALES (REUTILIZO CODIGO)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator ==(Producto a, Producto b)
        {
            bool retorno = false;
            if((Fabricante)a.fabricante == (Fabricante)b.fabricante && a.modelo == b.modelo)
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// RETORNA FALSE SI LOS MODELOS Y LOS FABRICANTES NO SON IGUALES
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

    }
}
