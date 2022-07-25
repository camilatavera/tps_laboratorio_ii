using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class NoHayDeporteException : Exception
    {
        public NoHayDeporteException(string mensaje) : base(mensaje)
        {}

        public NoHayDeporteException() : this("No se seleccionaron deportes") { }

    }
}
