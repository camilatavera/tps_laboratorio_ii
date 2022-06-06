using System;
using System.Xml.Serialization;

namespace Bibloteca
{

    
    [XmlInclude(typeof(EmpleadoOperativo))]

    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected Esexo sexo;
        protected DateTime fechaNacimiento;

        public Persona()
        {

        }

        protected Persona(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.FechaNacimiento = fechaNacimiento;
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

        /// <summary>
        /// Actualiza los valores de los atributos del objeto si corresponde
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <returns>bool</returns>
        public bool actualizarDatos(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento)
        {
            bool ret = false;
            if (this.nombre != nombre)
            {
                this.nombre = nombre;
                ret = true;
            }
            if (this.apellido != apellido)
            {
                this.apellido = apellido;
                ret = true;
            }
            if (this.sexo != sexo)
            {
                this.sexo = sexo;
                ret = true;
            }
            if (this.fechaNacimiento != fechaNacimiento)
            {
                this.fechaNacimiento = fechaNacimiento;
                ret = true;
            }
            return ret;
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
