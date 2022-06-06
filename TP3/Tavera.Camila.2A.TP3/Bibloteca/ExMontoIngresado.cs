using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class ExMontoIngresado:Exception
    {
        public ExMontoIngresado(string mensaje):base(mensaje)
        {

        }
    }
}
