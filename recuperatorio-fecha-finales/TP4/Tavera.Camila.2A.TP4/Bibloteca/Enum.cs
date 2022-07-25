using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
   public enum EDeporte
    {
        basket=2,
        handball=1,
        futbol=3,
    }

    public enum Esexo
    {
        f,
        m
    }

    public enum ECategoria
    {
        menores=1,
        juveniles=2,
        mayores=3,
    }

    public enum EArea
    {
        administrativo=1,
        ordenanza=2
    }

    public enum EForm
    {
        socio,
        empleado
    }

    public enum EFormEmpleado
    {
        deportivo,
        operativo
    }
}
