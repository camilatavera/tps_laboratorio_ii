using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExNoEsFederado:Exception
    {
        public ExNoEsFederado():base("Es socio, no federado")
        {

        }
    }
}
