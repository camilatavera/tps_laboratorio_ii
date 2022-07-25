using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class EmpleadoDeportivo:Persona, IEmpleado
    {
        
        List<Equipo> equipos;

        public EmpleadoDeportivo()
        {

        }

        public EmpleadoDeportivo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento) :
            base(nombre, apellido, sexo, fechaNacimiento)
        {
            equipos = new List<Equipo>();
           
           
        }


        /// <summary>
        /// Crea un equipo y lo agrega a la lista de equipos si no se repite.
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="deporte"></param>
        /// <param name="sexo"></param>
        /// <returns>bool</returns>
        public bool agregarEquipo(ECategoria categoria, EDeporte deporte, Esexo sexo)
        {
            Equipo equipo = new Equipo(categoria, deporte, sexo);
            return this + equipo;
        }


        /// <summary>
        /// Borra el equipo pasado por parametro de la lista de la clase
        /// </summary>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public bool borrarEquipo(Equipo equipo)
        {
            if(this - equipo)
            {
                return true;
            }
            return false;
        }

       

        /// <summary>
        /// Interfaz IEmpleado: calcula el sueldo del empleado deportivo
        /// </summary>
        /// <returns>int</returns>
        public int CalcularSueldo()
        {
            int sueldoBase = 80000;

            if (Equipos is not null && Equipos.Count > 1)
            {
                sueldoBase = sueldoBase + (Equipos.Count * 5000);
            }

            return sueldoBase;

        }

        /// <summary>
        /// propiedad de la interfaz: devuelve el metodo calcular sueldo
        /// </summary>
        public int Sueldo
        {
            get { return CalcularSueldo(); }
        }


       
        /// <summary>
        /// propiedad de lectura y escritura del atributo equipos
        /// </summary>
        public List<Equipo> Equipos
        {
            get { return this.equipos; }
            set { equipos = value; }
        }

        

        
        /// <summary>
        /// junta los datos mas imporantes del empleado
        /// </summary>
        /// <returns>string </returns>
        public override string ToString()
        {
            return $"{base.ToString()} - Deportivo";
        }

        /// <summary>
        /// Valida que la lista de equipos no tenga errores o incoherencias
        /// </summary>
        /// <param name="listaNueva"></param>
        /// <returns>bool</returns>
        public bool validarEquipos(List<Equipo> listaNueva)
        {
            bool ret = false;
            foreach (Equipo item in listaNueva)
            {
                if (!Equipos.Contains(item))
                {
                    Equipos.Add(item);
                    ret = true;
                }
            }

            foreach(Equipo item in Equipos)
            {
                if(!listaNueva.Contains(item))
                {
                    borrarEquipo(item);
                    ret = true;
                }
            }
            return ret;
        }

       

        public static bool operator +(EmpleadoDeportivo a, Equipo b)
        {
            if (a != b)
            {
                a.equipos.Add(b);
                return true;
            }
            return false;
        }

        public static bool operator -(EmpleadoDeportivo a, Equipo b)
        {
            if (a == b)
            {
                a.equipos.Remove(b);
                return true;
            }
            return false;
        }

        public static bool operator ==(EmpleadoDeportivo a, Equipo b)
        {
            foreach(Equipo item in a.equipos)
            {
                if (item == b)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(EmpleadoDeportivo a, Equipo b)
        {
            return !(a == b);
        }

    }
}
