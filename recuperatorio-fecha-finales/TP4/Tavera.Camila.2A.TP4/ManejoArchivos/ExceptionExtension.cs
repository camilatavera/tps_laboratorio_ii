using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoArchivos
{
    public class ExceptionExtension:Exception
    {
        public ExceptionExtension(string mensaje, Exception inner) : base(mensaje, inner) { }
        public ExceptionExtension(string mensaje):this(mensaje, null) { }

       
    }
}
