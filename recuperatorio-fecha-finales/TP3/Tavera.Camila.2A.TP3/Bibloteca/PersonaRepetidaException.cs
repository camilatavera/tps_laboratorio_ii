using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class PersonaRepetidaException:Exception
    {
        public PersonaRepetidaException(string mensaje): base(mensaje)
        {

        }
    }
}
