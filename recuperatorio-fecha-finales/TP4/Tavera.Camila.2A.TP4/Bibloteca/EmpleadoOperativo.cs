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

      

        public EmpleadoOperativo(int id, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area) :
            base(id, nombre, apellido, sexo, fechaNacimiento)
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


       

    }
}
