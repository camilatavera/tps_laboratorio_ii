using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public static class Extensiones
    {

        /// <summary>
        ///Devuelve el valor que tiene la primary key de Esexo en la base de datos
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string fkSexo(this Esexo valor)
        {
            if (valor == Esexo.f)
            {
                return "f";
            }
            else
            {
                return "m";
            }
        }
    }
}
