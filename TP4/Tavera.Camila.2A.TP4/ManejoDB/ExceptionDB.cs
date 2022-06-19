using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDB
{
    public class ExceptionDB:Exception
    {
        public ExceptionDB(string mensaje,  Exception inner):base(mensaje, inner)
        {

        }

        public ExceptionDB(string mensaje) : this($"ERROR EN LA BASE DE DATOS: {mensaje}", null)
        {

        }
    }
}
