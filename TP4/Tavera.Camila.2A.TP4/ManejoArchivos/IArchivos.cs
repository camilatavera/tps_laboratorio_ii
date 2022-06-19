using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoArchivos
{
    public interface IArchivos<T> where T:class
    {
        T Leer(string ruta);
        void Escribir(string path, T dato, bool append);
    }
}
