using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExPersonaRepetida:Exception
    {
        public ExPersonaRepetida(string mensaje): base(mensaje)
        {

        }
    }
}
