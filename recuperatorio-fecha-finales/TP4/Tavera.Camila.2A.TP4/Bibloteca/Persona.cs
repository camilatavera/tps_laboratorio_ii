using System;
using System.Xml.Serialization;

namespace Bibloteca
{

    
    

    public abstract class Persona
    {
        public int id;
        protected string nombre;
        protected string apellido;
        protected Esexo sexo;
        protected DateTime fechaNacimiento;

        

        protected Persona(int id, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
        }



        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// propiedad de lectura y escritura del atributo Nombre
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo Apellido
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo Sexo
        /// </summary>
        public Esexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }

        }


        /// <summary>
        /// propiedad de lectura y escritura del atributo FechaNacimiento
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }


        /// <summary>
        /// forma un string con los datos de la persona
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"Nombre completo: {Nombre} {Apellido} | Sexo: {Sexo} | Fecha: {FechaNacimiento.ToShortDateString()}";
        }

        

        public static bool operator ==(Persona a, Persona b)
        {
            return a.nombre == b.nombre && a.apellido == b.apellido;
        }

        public static bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }

       


    }
}
