using System;
using System.Xml.Serialization;

namespace Bibloteca
{

    //[XmlInclude(typeof(Socio))]
    //[XmlInclude(typeof(Federado))]
    [XmlInclude(typeof(EmpleadoDeportivo))]
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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Esexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }

        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }


        public override string ToString()
        {
            return $"Nombre completo: {Nombre} {Apellido} | Sexo: {Sexo} | Fecha: {FechaNacimiento.ToShortDateString()}";
        }


        public abstract string DatosGenerales { get; }

        public static bool operator ==(Persona a, Persona b)
        {
            return a.nombre == b.nombre && a.apellido == b.apellido;
        }

        public static bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }

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


    }
}
