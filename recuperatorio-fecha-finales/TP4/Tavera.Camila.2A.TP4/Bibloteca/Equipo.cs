using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{

    public class Equipo
    {
        ECategoria categoria;
        EDeporte deporte;
        Esexo sexo;
        int id;

        public Equipo()
        {

        }

        public Equipo(EDeporte deporte, ECategoria categoria, Esexo sexo)
        {
            this.categoria = categoria;
            this.deporte = deporte;
            this.sexo = sexo;
        }



        public Equipo(int id, EDeporte deporte, ECategoria categoria, Esexo sexo):this(deporte, categoria, sexo)
        {
            this.id = id;
        }
        public Equipo(ECategoria categoria, EDeporte deporte, Esexo sexo)
        {
            this.categoria = categoria;
            this.deporte = deporte;
            this.sexo = sexo;
        }

        /// <summary>
        /// propiedad de lectura y escritura del atributo categoria
        /// </summary>
        public ECategoria Categoria
        {
            set { categoria = value; }
            get { return categoria; }
                
        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo deporte
        /// </summary>
        public EDeporte Deporte
        {
            set { deporte = value; }
            get { return deporte; }

        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo sexo
        /// </summary>
        public Esexo Sexo
        {
            set { sexo = value; }
            get { return sexo; }

        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo id
        /// </summary>
        public int Id
        {
            set { id = value; }
            get { return id; }

        }

        /// <summary>
        /// escribe los atributos del objeto en una string
        /// </summary>
        /// <returns>string </returns>
        public override string ToString()
        {
            return $"Categoria: {this.categoria} | Deporte: {deporte} | Sexo: {sexo}";
        }


        /// <summary>
        /// Agrega el equipo a la lista si no esta incluido
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>bool</returns>
        public static bool operator +(List<Equipo> a, Equipo b)
        {
            foreach(Equipo item in a)
            {
                if (item == b)
                {
                    return false;
                }
            }
            a.Add(b);
            return true;
        }


        /// <summary>
        /// Compara dos equipos por sus atributos sin tener en cuenta el id
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>bool</returns>
        public static bool operator ==(Equipo a, Equipo b)
        {
            return (a.categoria == b.categoria && a.deporte == b.deporte && a.sexo == b.sexo);
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a==b);
        }

        /// <summary>
        /// Devuelve el equipo buscandolo por id en el atributos equipos de la clase Club
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator Equipo(int id)
        {
            foreach(Equipo item in Club.Equipos)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return null;
        }

        /// <summary>
        /// Devuelve el id del equipo que se le pasa por parametro buscandolo
        /// en el atributo equipos de clase Club
        /// </summary>
        /// <param name="equipo"></param>
        public static explicit operator int(Equipo equipo)
        {
            foreach (Equipo item in Club.Equipos)
            {
                if (equipo==item)
                {
                    return item.Id;
                }

            }
            return 0;
        }


        /// <summary>
        /// Devuelve el equipo del equipo
        /// </summary>
        /// <param name="idEquipo"></param>
        /// <returns>edeporte</returns>
        public static EDeporte TraerDeporte(int idEquipo)
        {
            Equipo equipo = (Equipo)idEquipo;
            return equipo.deporte;
        }

        public override bool Equals(object obj)
        {
            if(obj is Equipo)
            {
                return this == (Equipo)obj;
            }
            return false;
        }

    }
}
