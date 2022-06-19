using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class MontoIngresadoException:Exception
    {
        public MontoIngresadoException(string mensaje):base(mensaje)
        {

        }
    }
}
