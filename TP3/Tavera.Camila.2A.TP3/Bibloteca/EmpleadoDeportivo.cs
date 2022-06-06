using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class EmpleadoDeportivo:Persona, IDeportivos, IEmpleado
    {
        
        List<Equipo> equipos;

        public EmpleadoDeportivo()
        {

        }

        public EmpleadoDeportivo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos) :
            base(nombre, apellido, sexo, fechaNacimiento)
        {
            equipos = new List<Equipo>(equipos);
           
        }

        public bool agregarEquipo(ECategoria categoria, EDeporte deporte, Esexo sexo)
        {
            Equipo equipo = new Equipo(categoria, deporte, sexo);
            return this + equipo;
        }

        public bool borrarEquipo(Equipo equipo)
        {
            if(this - equipo)
            {
                return true;
            }
            return false;
        }

       


        int CalcularSueldo()
        {
            int sueldoBase = 80000;
            int cantEquipos = Equipos.Count;

            if (cantEquipos > 1)
            {
                sueldoBase = sueldoBase + (cantEquipos * 5000);
            }

            return sueldoBase;

        }

        public int Sueldo
        {
            get { return CalcularSueldo(); }
        }


        public override string DatosGenerales
        {
            get { return $"{base.ToString()} | Tipo: deportivo"; }
        }

        public List<Equipo> Equipos
        {
            get { return this.equipos; }
            set { equipos = value; }
        }

        

        

        public override string ToString()
        {
            return $"{base.ToString()} - Deportivo";
        }


        public bool validarEquipos(List<Equipo> listaNueva)
        {
            bool ret = false;
            foreach (Equipo item in listaNueva)
            {
                if (!Equipos.Contains(item))
                {
                    Equipos.Add(item);
                    ret = true;
                }
            }

            foreach(Equipo item in Equipos)
            {
                if(!listaNueva.Contains(item))
                {
                    borrarEquipo(item);
                    ret = true;
                }
            }
            return ret;
        }

        int IEmpleado.CalcularSueldo()
        {
            throw new NotImplementedException();
        }

        public static bool operator +(EmpleadoDeportivo a, Equipo b)
        {
            if (a != b)
            {
                a.equipos.Add(b);
                return true;
            }
            return false;
        }

        public static bool operator -(EmpleadoDeportivo a, Equipo b)
        {
            if (a == b)
            {
                a.equipos.Remove(b);
                return true;
            }
            return false;
        }

        public static bool operator ==(EmpleadoDeportivo a, Equipo b)
        {
            foreach(Equipo item in a.equipos)
            {
                if (item == b)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(EmpleadoDeportivo a, Equipo b)
        {
            return !(a == b);
        }

    }
}
