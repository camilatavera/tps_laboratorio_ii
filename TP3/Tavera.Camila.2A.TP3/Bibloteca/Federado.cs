using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class Federado:Socio, IDeportivos
    {
        List<EDeporte> deportes;


        public Federado()
        {

        }

       

        public Federado(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes) :
            base(nombre, apellido, sexo, fechaNacimiento, categoria)
        {
            this.deportes = new List<EDeporte>();
            this.deportes.AddRange(deportes);
            generarDeuda();
        }

        


        public Federado(Socio socio, List<EDeporte> deportes) :this(socio.Nombre, socio.Apellido, socio.Sexo, socio.FechaNacimiento, socio.Categoria, deportes)
        {

        }

       public List<EDeporte> Deportes
        {
            get { return deportes; }
        }


        public void agregarDeporte(EDeporte deporte)
        {
            if (!(this + deporte))
            {
                throw new ExDeporteRepetido(deporte.ToString()); ;
            }
        }

        protected override int calcularCuota()
        {
            if(Deportes is null)
            {
                return 0;
            }

            int cuota = base.calcularCuota();

            foreach(EDeporte deporte in deportes)
            {
                if (deporte == EDeporte.basket || deporte == EDeporte.handball)
                {
                    cuota += 1500;
                }
                else
                    cuota += 1200;
            }

            return cuota;
        }


        public static bool operator ==(Federado federado, EDeporte deporte)
        {
            foreach(EDeporte item in federado.deportes)
            {
                if (item == deporte)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Federado federado, EDeporte deporte)
        {
            return !(federado == deporte);
        }


        public static bool operator +(Federado federado, EDeporte deporte)
        {
            if (federado != deporte)
            {
                federado.deportes.Add(deporte);
                return true;
            }

            return false;
        }

        public static bool operator -(Federado federado, EDeporte deporte)
        {
            if (federado == deporte)
            {
                federado.deportes.Remove(deporte);
                return true;
            }

            return false;
        }

        public bool borrarDeporte(EDeporte deporte)
        {
            return this - deporte;
        }




        private string devolverDeportes()
        {
            StringBuilder sb = new StringBuilder();
            foreach(EDeporte item in deportes)
            {
                sb.Append($"{item.ToString()} - ");
            }
            return sb.ToString();
        }

        public override string ToString()
        {      
             return $"{base.ToString()} | Federado: Si"; 
        }

      

       
       
        public bool validarDeportes(List<EDeporte> deportesNuevos)
        {
            if (deportesNuevos is null || deportesNuevos.Count ==0)
            {
                throw new ExNoHayDeportes();
            }

            if(this.Deportes.Count!=deportesNuevos.Count)
            {
                return limpiarDeportes(deportesNuevos);
            }
            else
            {
               foreach(EDeporte item in deportesNuevos)
               {
                    if (this.Deportes.Contains(item))
                    {
                        return limpiarDeportes(deportesNuevos);
                    }
               }
            }
               
            return false;
        }

        private bool limpiarDeportes(List<EDeporte> deportesNuevos)
        {
            this.Deportes.Clear();
            this.Deportes.AddRange(deportesNuevos);
            return true;
        }


    }
}
