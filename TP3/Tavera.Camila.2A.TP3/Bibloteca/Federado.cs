﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class Federado:Socio
    {
        List<EDeporte> deportes;


      
        public Federado(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes) :
            base(nombre, apellido, sexo, fechaNacimiento, categoria)
        {
            this.deportes = new List<EDeporte>();
            this.deportes.AddRange(deportes);
            generarDeuda();
        }

        


       
        /// <summary>
        /// propiedad de lectura del atributo deportes
        /// </summary>
       public List<EDeporte> Deportes
        {
            get { return deportes; }
        }


        /// <summary>
        /// agrega un deporte a la lista o larga una excepcion en caso de que el deporte ya este en la lista
        /// </summary>
        /// <param name="deporte"></param>
        public void agregarDeporte(EDeporte deporte)
        {
            if (!(this + deporte))
            {
                throw new ExDeporteRepetido(deporte.ToString()); ;
            }
        }


        /// <summary>
        /// calcula la cuota social del objeto
        /// </summary>
        /// <returns>int</returns>
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

        /// <summary>
        /// Borra el deporte de la lista si lo eencuentra
        /// </summary>
        /// <param name="deporte"></param>
        /// <returns>bool</returns>
        public bool borrarDeporte(EDeporte deporte)
        {
            return this - deporte;
        }



        /// <summary>
        /// Devuelve un string con los deportes del federado
        /// </summary>
        /// <returns>string</returns>
        private string devolverDeportes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (EDeporte item in deportes)
            {
                sb.Append($"{item.ToString()} - ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Valida que los deportes de la lista pasado por parametro coincidan con los de la lista 
        /// del atributo de la clase
        /// </summary>
        /// <param name="deportesNuevos"></param>
        /// <returns>bool</returns>
        public bool validarDeportes(List<EDeporte> deportesNuevos)
        {
            if (deportesNuevos is null || deportesNuevos.Count == 0)
            {
                throw new ExNoHayDeportes();
            }

            if (this.Deportes.Count != deportesNuevos.Count)
            {
                return limpiarDeportes(deportesNuevos);
            }
            else
            {
                foreach (EDeporte item in deportesNuevos)
                {
                    if (this.Deportes.Contains(item))
                    {
                        return limpiarDeportes(deportesNuevos);
                    }
                }
            }

            return false;
        }



        /// <summary>
        /// limpia la lista de deportes del atributo
        /// </summary>
        /// <param name="deportesNuevos"></param>
        /// <returns>bool</returns>
        private bool limpiarDeportes(List<EDeporte> deportesNuevos)
        {
            this.Deportes.Clear();
            this.Deportes.AddRange(deportesNuevos);
            return true;
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

       

        public override string ToString()
        {      
             return $"{base.ToString()} | Federado: Si"; 
        }

      

       
       
       


    }
}
