using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_2
{
    public class Deposito
    {
        int capacidad;
        List<Producto> productos;

        private Deposito()
        {
            this.productos = new List<Producto>();
        }
        private Deposito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// PROPIEDAD QUE RETORNA EL PRECIO DE LOS CELULARES SEGUN LO QUE RETORNA EL METODO PARA OBTENER EL PRECIO
        /// </summary>
        public double PrecioDeCelulares
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeCelulares);
            }
        }
        /// <summary>
        /// PROPIEDAD QUE RETORNA EL PRECIO DE LOS TELEVISORES SEGUN LO QUE RETORNA EL METODO PARA OBTENER EL PRECIO
        /// </summary>
        public double PrecioDeTelevisores
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioDeTelevisores);
            }
        }

        /// <summary>
        /// PROPIEDAD QUE RETORNA EL PRECIO DE TODOS LOS PRODUCTOS SEGUN LO QUE RETORNA EL METODO PARA OBTENER EL PRECIO
        /// </summary>
        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(EProducto.PrecioTotal);
            }
        }


        /// <summary>
        /// RETORNA LOS DETALLES DEL DEPOSITO MAS TODOS LOS PRODUCTOS QUE CONTIENE DENTRO Y SUS DETALLES
        /// </summary>
        /// <param name="d"></param>
        /// <returns>STRING</returns>
        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine($"Capacidad: {d.capacidad} ({d.capacidad})");
            sb.AppendLine($"Total por televisores: {d.PrecioDeTelevisores}");
            sb.AppendLine($"Total por celulares: {d.PrecioDeCelulares}");
            sb.AppendLine($"Total: {d.PrecioTotal}");
            sb.AppendLine("********************************************************************************");
            sb.AppendLine("Listado de productos");
            sb.AppendLine("********************************************************************************");
            foreach (Producto item in d.productos)
            {
                if(item is Televisor)
                {
                    sb.AppendLine(((Televisor)item).ToString());
                }
                else
                {
                    if(item is Celular)
                    {
                        sb.AppendLine(((Celular)item).ToString());
                    }
                }
            }
            return sb.ToString();
        }


        /// <summary>
        /// RETORNA LA INSTANCIA DE UN DEPOSITO QUE COINCIDA CON LA CAPACIDAD QUE SE LE PASA COMO PARAMETRO
        /// </summary>
        /// <param name="capacidad"></param>
        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }


        /// <summary>
        /// RETORNA TRUE SI UN PRODUCTO YA SE ENCUENTRA EN EL DEPOSITO
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator == (Deposito d, Producto p)
        {
            bool retorno = false;
            if(d.productos.Contains(p))
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// RETORNA FALSE SI UN PRODUCTO NO SE ENCUENTRA EN EL DEPOSITO
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns>FALSE</returns>
        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        /// <summary>
        /// RETORNA UN DEPOSITO CON UN PRODUCTO AGREGADO O NO
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns>UN DEPOSITO</returns>
        public static Deposito operator + (Deposito d, Producto p)
        {
            Deposito retorno = d;

            if(d.capacidad > d.productos.Count)
            {
                if(d != p)
                {
                    d.productos.Add(p);
                    retorno = d;
                }
                else
                {
                    Console.WriteLine("El producto ya se encuentra en el deposito");
                    retorno = d;
                }
            }
            else
            {
                Console.WriteLine("El deposito no tiene mas capacidad para almacenar un producto");
                retorno = d;
            }

            return retorno;
        }


        /// <summary>
        /// RETORNA EL PRECIO CALCULADO SEGUN EL TIPO DE PRODUCTO
        /// </summary>
        /// <param name="tipoProducto"></param>
        /// <returns>DOUBLE</returns>
        private double ObtenerPrecio(EProducto tipoProducto)
        {
            double precio = 0;

            foreach (Producto item in this.productos)
            {
                switch (tipoProducto)
                {
                    case EProducto.PrecioDeTelevisores:
                        if(item is Televisor)
                        {
                            precio = ((Televisor)item).Precio;
                        }
                    break;
                    case EProducto.PrecioDeCelulares:
                        if (item is Celular)
                        {
                            precio = ((Celular)item).Precio;
                        }
                    break;
                    case EProducto.PrecioTotal:
                        if (item is Televisor)
                        {
                            precio = ((Televisor)item).Precio;
                        }
                        else
                        {
                            if (item is Celular)
                            {
                                precio = ((Celular)item).Precio;
                            }
                        }
                    break;
                }
            }

            return precio;
        }
    }
}
