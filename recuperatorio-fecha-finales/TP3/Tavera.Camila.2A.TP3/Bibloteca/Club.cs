using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public static class Club
    {
        static string nombre;
        static List<Socio> socios;
        static List<Federado> federados;
        static List<EmpleadoDeportivo> deportivos;
        static List<EmpleadoOperativo> operativos;


        static Club()
        {
            socios = new List<Socio>();
            federados = new List<Federado>();
            deportivos = new List<EmpleadoDeportivo>();
            operativos = new List<EmpleadoOperativo>();

            SociosIniciales();

        }

        /// <summary>
        /// Propiedad de lectura del atributo Socios
        /// </summary>
        public static List<Socio> Socios
        {
            get { return socios; }
        }


        /// <summary>
        /// Propiedad de lectura del atributo Federados
        /// </summary>
        public static List<Federado> Federados
        {
            get { return federados; }
        }



        /// <summary>
        /// Propiedad de lectura del atributo Deportivos
        /// </summary>
        public static List<EmpleadoDeportivo> Deportivos
        {
            get { return deportivos; }
        }


        /// <summary>
        /// Propiedad de lectura del atributo Operativos
        /// </summary>
        public static List<EmpleadoOperativo> Operativos
        {
            get { return operativos; }
        }



        /// <summary>
        /// Busca el objeto que se pasa por parametro en la lista Federados de la clase
        /// </summary>
        /// <param name="federado"></param>
        /// <returns>objeto encontrado o null</returns>
        public static Federado BuscarFederado(Socio federado)
        {
            foreach(Federado item in federados)
            {
                if(item==federado)
                {
                    return item;
                }
            }
            return null;
            
        }


        /// <summary>
        /// Busca el objeto que se pasa por parametro en la lista Socios de la clase
        /// </summary>
        /// <param name="federado"></param>
        /// <returns>objeto encontrado o null</returns>
        public static Socio BuscarSocio(Socio socio)
        {
            foreach (Socio item in socios)
            {
                if (item == socio)
                {
                    return item;
                }
            }
            return null;

        }


        /// <summary>
        /// crea y agrega un federado a la lista federados de la clase
        /// En caso de estar repetido lanza una excepcion 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <param name="deportes"></param>
        /// <returns></returns>
        public static bool AgregarFederado(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes)
        {

            Federado nuevoFederado = new Federado(nombre, apellido, sexo, fechaNacimiento, categoria, deportes);
            foreach(Federado item in federados)
            {
                if (item == nuevoFederado)
                {
                    throw new PersonaRepetidaException($"El federado {apellido} ya esta anotado");
                }
            }

            federados.Add(nuevoFederado);
            return true;

        }


        /// <summary>
        /// crea y agrega un socio a la lista socios de la clase
        /// En caso de estar repetido lanza una excepcion 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <param name="deportes"></param>
        /// <returns>true o lanza excepcion</returns>
        public static bool AgregarSocio(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        {
           Socio socio = new Socio(nombre, apellido, sexo, fechaNacimiento, categoria);
            foreach (Socio item in socios)
            {
                if (item == socio)
                {
                    throw new PersonaRepetidaException($"El socio {apellido} ya esta anotado");
                }
            }

            socios.Add(socio);
            return true;

        }


        /// <summary>
        /// crea y agrega un emepleado deportivo a la lista deportivos de la clase
        /// En caso de estar repetido lanza una excepcion 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <param name="deportes"></param>
        /// <returns>true o lanza excepcion</returns>
        public static bool AgregarDeportivo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos)
        {
            EmpleadoDeportivo deportivo = new EmpleadoDeportivo(nombre, apellido, sexo, fechaNacimiento);
            foreach (EmpleadoDeportivo item in Deportivos)
            {
                if (item == deportivo)
                {
                    throw new PersonaRepetidaException($"El Empleado Deportivo {apellido} ya esta anotado");
                }
            }

            foreach(Equipo item in equipos)
            {
                bool a=deportivo + item;
            }

            deportivos.Add(deportivo);
            return true;
        }



        public static bool AgregarOperativo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {
            EmpleadoOperativo operativo = new EmpleadoOperativo(nombre, apellido, sexo, fechaNacimiento, area);
            foreach (EmpleadoOperativo item in Operativos)
            {
                if (item == operativo)
                {
                    throw new PersonaRepetidaException($"El Empleado Operativo {apellido} ya esta anotado");
                }
            }

            operativos.Add(operativo);
            return true;
        }

        /// <summary>
        /// autaliza los atributos del objeto si corresponde
        /// </summary>
        /// <param name="socio"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <returns>bool</returns>
        public static bool UpdateSocio(Socio socio, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        {
            Socio aux;
            for (int i = 0; i < Socios.Count; i++)
            {
                aux = socios[i];
                if (aux == socio)
                {
                    return aux.ActualizarDatos(nombre, apellido, sexo, fechaNacimiento,categoria);
                }
            }

            return false;
        }

        /// <summary>
        /// autaliza los atributos del objeto si corresponde
        /// </summary>
        /// <param name="federado"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <param name="deportes"></param>
        /// <returns>bool </returns>
        public static bool UpdateFederado(Federado federado, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes)
        {
            Federado aux;
            bool ret1;
            bool ret2;
            
            try
            {
                for (int i = 0; i < Federados.Count; i++)
                {
                    aux = Federados[i];
                    if (aux == federado)
                    {
                        ret1=aux.ActualizarDatos(nombre, apellido, sexo, fechaNacimiento, categoria);
                        ret2= federado.ValidarDeportes(deportes);
                        return ret1||ret2;

                    }
                }
            }
            catch (NoHayDeporteException)
            {
                throw;
            }

            
            return false;          
        }


        /// <summary>
        /// autaliza los atributos del objeto si corresponde
        /// </summary>
        /// <param name="deportivo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="deportes"></param>
        /// <returns>bool</returns>
        public static bool UpdateDeportivo(EmpleadoDeportivo deportivo, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> deportes)
        {
            
            EmpleadoDeportivo aux;
            bool ret1;
            bool ret2;

            try
            {
                for (int i = 0; i < Deportivos.Count; i++)
                {
                    aux = Deportivos[i];
                    if (aux == deportivo)
                    {
                        ret1 = ((Persona)aux).ActualizarDatos(nombre, apellido, sexo, fechaNacimiento);
                        ret2 = aux.ValidarEquipos(deportes);
                        return ret1 || ret2;

                    }
                }
            }
            catch (NoHayDeporteException)
            {
                throw;
            }


            return false;
        }


        /// <summary>
        /// autaliza los atributos del objeto si corresponde
        /// </summary>
        /// <param name="operativo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="area"></param>
        /// <returns>bool</returns>
        public static bool UpdateOperativo(EmpleadoOperativo operativo, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        {
            EmpleadoOperativo aux;
            for (int i = 0; i < Socios.Count; i++)
            {
                aux = operativos[i];
                if (aux == operativo)
                {
                    return aux.ActualizarDatos(nombre, apellido, sexo, fechaNacimiento, area);
                }
            }

            return false;
        }


        /// <summary>
        /// Busca al objeto pasado por parametro en la lista Operativos de la clase
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>EmpleadoOperativo o null</returns>
        public static EmpleadoOperativo BuscarOperativo(Persona persona)
        {
            foreach(EmpleadoOperativo item in Operativos)
            {
                if (persona == (Persona)item)
                {
                    return item;
                }
            }
            return null;
        }


        /// <summary>
        /// Busca al objeto pasado por parametro en la lista Deportivos de la clase
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>EmpleadoDeportivo o null</returns>
        public static EmpleadoDeportivo BuscarDeportivo(Persona persona)
        {
            foreach (EmpleadoDeportivo item in Deportivos)
            {
                if (persona == (Persona)item)
                {
                    return (EmpleadoDeportivo)item;
                }
            }
            return null;
        }


        /// <summary>
        /// llama a la clase socio para generar la factura
        /// </summary>
        /// <param name="socio"></param>
        /// <param name="montoIngresado"></param>
        /// <returns>string</returns>
        public static string GenerarFactura(Socio socio, int montoIngresado)
        {
            return socio.EscribirFactura(montoIngresado);

        }

        /// <summary>
        /// Buscar al socio en la lista socios de la clase y lo borra
        /// </summary>
        /// <param name="socio"></param>
        /// <returns>bool</returns>
        public static bool BorrarSocio(Socio socio)
        {
            for (int i = 0; i < socios.Count; i++)
            {
                if (socios[i] == socio)
                {
                    Socios.RemoveAt(i);
                    return true;
                }
            }

            return false;
            
        }


        /// <summary>
        /// Buscar al elemento pasado por parametro en la lista Federados de la clase y lo borra
        /// </summary>
        /// <param name="federado"></param>
        /// <returns>bool</returns>
        public static bool BorrarFederado(Federado federado)
        {
            for (int i = 0; i < federados.Count; i++)
            {
                if (federados[i] == federado)
                {
                    Federados.RemoveAt(i);
                    return true;
                }
            }

            return false;

        }


        /// <summary>
        /// Crea los objetos iniciales y los agrega a la lista correspondiente.
        /// </summary>
        private static void SociosIniciales()
        {
            Socio socio4 = new Socio("Mariano", "Gomez", Esexo.m, new DateTime(2004, 4, 4), ECategoria.menores);
            Socio socio5 = new Socio("Emilia", "Kinga", Esexo.f, new DateTime(1963, 09, 01), ECategoria.mayores);
            Socio socio6 = new Socio("Julia", "Menga", Esexo.f, new DateTime(2000, 12, 21), ECategoria.juveniles);
            Socio socio7 = new Socio("Lucio", "Lunix", Esexo.m, new DateTime(1980, 12, 01), ECategoria.mayores);
            Socio socio8 = new Socio("Marcos", "Ludovico", Esexo.m, new DateTime(2010, 12, 21), ECategoria.menores);
            Socio socio9 = new Socio("Roberto", "Roman", Esexo.m, new DateTime(2005, 12, 21), ECategoria.juveniles);


            List<EDeporte> deportes1 = new List<EDeporte>();
            deportes1.Add(EDeporte.handball);
            deportes1.Add(EDeporte.futbol);

            List<EDeporte> deportes2 = new List<EDeporte>();
            deportes2.Add(EDeporte.futbol);

            List<EDeporte> deportes3 = new List<EDeporte>();
            deportes3.Add(EDeporte.handball);
            deportes3.Add(EDeporte.basket);

            Federado federado1 = new Federado("Francisco", "Henaren", Esexo.m, new DateTime(2000, 12, 21), ECategoria.juveniles, deportes1);
            Federado federado2 = new Federado("Nicolas", "Sazz", Esexo.m, new DateTime(1987, 04, 21), ECategoria.mayores, deportes2);
            Federado federado3 = new Federado("Matilda", "Monte", Esexo.m, new DateTime(1980, 03, 21), ECategoria.mayores, deportes3);

            Equipo equipo1 = new Equipo(ECategoria.menores, EDeporte.handball, Esexo.m);
            Equipo equipo2 = new Equipo(ECategoria.juveniles, EDeporte.handball, Esexo.m);
            Equipo equipo3 = new Equipo(ECategoria.juveniles, EDeporte.handball, Esexo.m);
            Equipo equipo4 = new Equipo(ECategoria.mayores, EDeporte.handball, Esexo.m);
            Equipo equipo5 = new Equipo(ECategoria.menores, EDeporte.handball, Esexo.m);
            Equipo equipo6 = new Equipo(ECategoria.mayores, EDeporte.handball, Esexo.m);
            Equipo equipo7 = new Equipo(ECategoria.menores, EDeporte.handball, Esexo.m);
            Equipo equipo8 = new Equipo(ECategoria.mayores, EDeporte.handball, Esexo.m);
            Equipo equipo69 = new Equipo(ECategoria.juveniles, EDeporte.handball, Esexo.m);



            List<Equipo> listEquipo1 = new List<Equipo>();
            listEquipo1.Add(equipo1);
            listEquipo1.Add(equipo2);
            listEquipo1.Add(equipo3);

            List<Equipo> listEquipo2 = new List<Equipo>();
            listEquipo2.Add(equipo4);
            listEquipo2.Add(equipo5);

            List<Equipo> listEquipo3 = new List<Equipo>();
            listEquipo3.Add(equipo6);

            EmpleadoDeportivo deportivo3 = new EmpleadoDeportivo("Jose", "Mexon", Esexo.m, new DateTime(1985, 07, 15));

            bool a = deportivo3 + equipo1;
            a = deportivo3 + equipo2;


            socios.Add(socio4);
            socios.Add(socio5);
            socios.Add(socio6);
            socios.Add(socio7);
            socios.Add(socio8);
            socios.Add(socio9);

            federados.Add(federado1);
            federados.Add(federado2);
            federados.Add(federado3);

            deportivos.Add(deportivo3);




        }





    }
}
