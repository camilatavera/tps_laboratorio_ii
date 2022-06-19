using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class DeporteRepetidoException:Exception
    {
        public DeporteRepetidoException(string deporte):base($"El federado ya esta anotado en {deporte}")
        {

        }
    }
}
