using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_1
{
    public class Grupo
    {
        List<Mascota> manada;
        string nombre;
        static EtipoManada tipo;

        /// <summary>
        /// CONSTRUCTOR DE CLASE QUE INICIALIZA EL TIPO DE MANADA
        /// </summary>
        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }

        /// <summary>
        /// CONSTRUCTOR PRIVADO QUE INICIALIZA LA LISTA DE MASCOTAS
        /// </summary>
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR QUE INICIALIZA EL NOMBRE CON LO QUE SE PASA COMO PARAMETRO
        /// </summary>
        /// <param name="nombre"></param>
        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// SOBRECARGA DE CONSTRUCTOR QUE INICIALIZA EL TIPO DE MANADA CON LO QUE SE PASA COMO PARAMETRO
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipo"></param>
        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }


        /// <summary>
        /// PROPIEDAD DE SOLO ESCRITURA PARA EL ATRIBUTO DE TIPO MANADA
        /// </summary>
        public EtipoManada Tipo
        {
            set
            {
                Grupo.tipo = value;
            }
        }
        
        /// <summary>
        /// SOBRECARGA QUE RETORNA TRUE SI UNA MASCOTA SE ENCUENTRA EN EL GRUPO
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator == (Grupo g, Mascota m)
        {
            bool retorno = false;

            if(g is not null && m is not null)
            {
                if (g.manada.Contains(m))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// SOBRECARGA CONTRARIA A LA DE ARRIBA
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns>TRUE O FALSE</returns>
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        /// <summary>
        /// SOBRECARGA QUE SE ENCARGA DE AGREGAR UNA MASCOTA AL GRUPO SI ESTA NO SE ENCUENTRA EN EL; CASO
        /// CONTRARIO, LO INFORMA.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns>UN GRUPO</returns>
        public static Grupo operator + (Grupo g, Mascota m)
        {
            if(g is not null && m is not null)
            {
                if(g != m)
                {
                    g.manada.Add(m);
                    return g;
                }
                else
                {
                    if (m is Perro)
                    {
                        int edad = (Perro)m;
                        Console.WriteLine("Ya esta {0} - {1} - {2}, edad {3} en el grupo", m.GetType().Name, m.Nombre, m.Raza, edad);
                    }
                    else
                    {
                        if (m is Gato)
                        {
                            Console.WriteLine("Ya esta {0} - {1} - {2} en el grupo", m.GetType().Name, m.Nombre, m.Raza);
                        }
                    }
                }
                return g;
            }
            return g;
        }


        /// <summary>
        /// SOBRECARGA QUE SE ENCARGA DE ELIMINAR UNA MASCOTA DEL GRUPO SI ESTA YA SE ENCUENTRA EN EL; CASO CONTRARIO
        /// INFORMA
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns>UN GRUPO</returns>
        public static Grupo operator - (Grupo g, Mascota m)
        {
            if(g is not null && m is not null)
            {
                if(g == m)
                {
                    g.manada.Remove(m);
                    return g;
                }
                else
                {
                    if (m is Perro)
                    {
                        int edad = (Perro)m;
                        Console.WriteLine("No esta el {0} - {1} - {2}, edad {3} en el grupo", m.GetType().Name, m.Nombre, m.Raza, edad);
                    }
                    else
                    {
                        if (m is Gato)
                        {
                            Console.WriteLine("No esta el {0} - {1} - {2} en el grupo", m.GetType().Name, m.Nombre, m.Raza);
                        }
                    }
                }

                return g;
            }
            return g; ;
        }


        /// <summary>
        /// SOBRECARGA DE CONVERSION IMPLCITA QUE RETORNA LOS DATOS DE UN GRUPO DE MASCOTAS CON SUS RESPECTIVOS 
        /// DETALLES EN FORMATO STRING
        /// </summary>
        /// <param name="g"></param>
        public static implicit operator string (Grupo g)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendLine($"Grupo: {g.nombre} - Tipo: {Grupo.tipo}");
            sb.AppendLine($"Integrantes: ({g.manada.Count})");
            foreach (Mascota item in g.manada)
            {
                if(item is Perro)
                {
                    sb.AppendLine($"{((Perro)item).ToString()}");
                }
                else
                {
                    if(item is Gato)
                    {
                        sb.AppendLine($"{((Gato)item).ToString()}");
                    }
                }
            }

            return sb.ToString();
        }



    }
}
