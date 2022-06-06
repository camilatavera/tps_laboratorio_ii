using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class EmpleadoOperativo:Persona, IEmpleado
    {

        EArea area;

        public EmpleadoOperativo()
        {

        }

        public EmpleadoOperativo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area) :
            base(nombre, apellido, sexo, fechaNacimiento)
        {
            this.area = area;
        }

        public EArea Area
        {
            get { return area; }
            set { area = value; }
        }

        public override string DatosGenerales
        {
            get { return $"{base.ToString()} | Tipo: operativo - {this.area}"; }
        }

        public int Sueldo
        {
            get { return CalcularSueldo(); }
        }

        public int CalcularSueldo()
        {
            if (area == EArea.ordenanza)
            {
                return 70000;
            }
            else
            {
                return 85000;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Operativo - {area}";
        }

        public bool actualizarDatos(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {
            bool ret = actualizarDatos(nombre, apellido, sexo, fechaNacimiento);
            if (this.area != area)
            {
                this.area = area;
                ret = true;
            }

            return ret;
        }




    }
}
