using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class EquipoSinCupoException:Exception
    {
        public EquipoSinCupoException(int cupoMax, EDeporte deporte) : base($"El deporte {deporte} tiene el cupo lleno ({cupoMax})")
        {

        }
    }
}
