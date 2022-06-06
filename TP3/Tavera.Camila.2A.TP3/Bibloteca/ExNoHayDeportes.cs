using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExNoHayDeportes : Exception
    {
        public ExNoHayDeportes(string mensaje) : base(mensaje)
        {}

        public ExNoHayDeportes() : this("No se seleccionaron deportes") { }

    }
}
