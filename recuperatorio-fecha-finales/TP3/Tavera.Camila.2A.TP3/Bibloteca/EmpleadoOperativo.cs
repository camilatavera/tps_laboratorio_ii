using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class EmpleadoOperativo:Persona, IEmpleado
    {

        EArea area;

        public EmpleadoOperativo()
        {

        }

        public EmpleadoOperativo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area) :
            base(nombre, apellido, sexo, fechaNacimiento)
        {
            this.area = area;
        }

        /// <summary>
        /// propiedad de lectura y escritura del atributo area
        /// </summary>
        public EArea Area
        {
            get { return area; }
            set { area = value; }
        }


        /// <summary>
        /// propiedad de lectura que llama a calcular el sueldo
        /// </summary>
        public int Sueldo
        {
            get { return CalcularSueldo(); }
        }

        /// <summary>
        /// calcula el sueldo dependiendo del area
        /// </summary>
        /// <returns>int</returns>
        public int CalcularSueldo()
        {
            if (area == EArea.ordenanza)
            {
                return 70000;
            }
            else
            {
                return 85000;
            }
        }

        /// <summary>
        /// forma una cadena con la  informacion del empleado
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return $"{base.ToString()} - Operativo - {area}";
        }


        /// <summary>
        /// Actualiza los datos del empleado si corresponde
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="area"></param>
        /// <returns>bool </returns>
        public bool ActualizarDatos(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {
            bool ret = ActualizarDatos(nombre, apellido, sexo, fechaNacimiento);
            if (this.area != area)
            {
                this.area = area;
                ret = true;
            }

            return ret;
        }




    }
}
