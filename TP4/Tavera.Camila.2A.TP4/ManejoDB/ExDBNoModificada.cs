using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDB
{
    public class ExDBNoModificada:Exception
    {
        public ExDBNoModificada(string msj, Exception inner):base(msj, inner) { }

        public ExDBNoModificada() : this("No se encontro lo buscado", null) { }
    }
}
