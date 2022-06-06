using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public interface IEmpleado
    {

        /// <summary>
        /// Calcula el sueldo
        /// </summary>
        /// <returns>int:sueldo del empleado</returns>
        int CalcularSueldo();


        /// <summary>
        /// propiedad de lectura del sueldo.
        /// </summary>
        public int Sueldo { get; }

        

    }
}
