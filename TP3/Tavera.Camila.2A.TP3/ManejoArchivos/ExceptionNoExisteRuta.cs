using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoArchivos
{
    public class ExceptionNoExisteRuta:Exception
        
    {
        public ExceptionNoExisteRuta(string message) : base(message) { }
        public ExceptionNoExisteRuta(string message, Exception inner)         :this(message)  
        {
                
        }
    }
}
