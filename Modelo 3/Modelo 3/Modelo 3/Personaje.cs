using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo_3
{
    public abstract class Personaje
    {
        List<EHabilidades> listaHabilidades;
        protected string nombre;

        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }

        public Personaje(List<EHabilidades> listaHabilidades, string nombre) : this()
        {
            this.listaHabilidades = listaHabilidades;
            this.nombre = nombre;
        }


        /// <summary>
        /// PROPIEDAD QUE RETORNA TODAS LAS HABILIDADES DE UN PERSONAJE
        /// </summary>
        private string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder("");
                sb.AppendLine("Habilidades: ");
                foreach (EHabilidades item in this.listaHabilidades)
                {
                    sb.AppendLine(item.ToString());
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// PROPIEDAD ABSTRACTA Y PROTEGIDA QUE RETORNA EL NOMBRE DE UN PERSONAE
        /// </summary>
        protected abstract string Nombre { get; }


        /// <summary>
        /// COMPARA UNA LISTA DE PERSONAJES CON UN PERSONAJE (COMPARA POR NOMBRE Y TIPO)
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool operator == (List<Personaje> listaPersonajes, Personaje personaje)
        {
            bool retorno = false;
            foreach (Personaje item in listaPersonajes)
            {
                if (item.Nombre == personaje.Nombre)
                {
                    if(item.GetType() == personaje.GetType())
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }


        /// <summary>
        /// RETORNA FALSE SI UN PERSONAJE NO SE ENCUENTRA EN LA LISTA
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }


        /// <summary>
        /// AGREGA UN PERSONAJE A LA LISTA
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static List<Personaje> operator + (List<Personaje> lista, Personaje personaje)
        {
            if(lista!= personaje)
            {
                lista.Add(personaje);
                return lista;
            }

            return lista;
        }


        /// <summary>
        /// ME RETORNA EL NOMBRE DEL PERSONAJE Y TODAS SUS HABILIDADES
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.ListaHabilidades);
            return sb.ToString();
        }




    }
}
