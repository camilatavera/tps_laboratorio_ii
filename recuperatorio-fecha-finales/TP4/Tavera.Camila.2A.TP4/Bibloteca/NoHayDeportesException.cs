using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class NoHayDeportesException : Exception
    {
        public NoHayDeportesException(string mensaje) : base(mensaje)
        {}

        public NoHayDeportesException() : this("No se seleccionaron deportes") { }

    }
}
