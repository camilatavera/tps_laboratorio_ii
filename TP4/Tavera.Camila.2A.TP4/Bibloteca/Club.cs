    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ManejoArchivos;

namespace Bibloteca
{
    public static class Club
    {
        static string nombre;
        static List<Socio> socios;
        static List<Federado> federados;
        static List<EmpleadoDeportivo> deportivos;
        static List<EmpleadoOperativo> operativos;
        static List<Equipo> equipos;
        public static event Action<string> eventoAviso;
        static int cantidadEquipos;

        static Club()
        {
            cantidadEquipos = 18;
            socios = new List<Socio>();
            federados = new List<Federado>();
            deportivos = new List<EmpleadoDeportivo>();
            operativos = new List<EmpleadoOperativo>();
            equipos = new List<Equipo>();

            //sociosIniciales();

        }

        public static int CantidadEquipos
        {
            get { return cantidadEquipos; }
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
            set { federados = value; }
        }

        public static List<Equipo> Equipos
        {
            get { return equipos; }
            set { equipos = value; }
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
        public static Federado buscarFederado(Socio federado)
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
        public static Socio buscarSocio(Socio socio)
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
        //public static bool agregarFederado(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes)
        //{

        //    Federado nuevoFederado = new Federado(id, nombre, apellido, sexo, fechaNacimiento, categoria, deportes);
        //    foreach(Federado item in federados)
        //    {
        //        if (item == nuevoFederado)
        //        {
        //            throw new ExPersonaRepetida($"El federado {apellido} ya esta anotado");
        //        }
        //    }

        //    federados.Add(nuevoFederado);
        //    return true;

        //}


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
        public static void AgregarSocio(int id, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int deuda)
        {
            Socio socio = new Socio(id, nombre, apellido, sexo, fechaNacimiento, categoria, deuda);
            socios.Add(socio);

        }

        public static Federado AgregarFederado(int id, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, int deuda, List<EDeporte> deportes)
        {
            Federado federado = new Federado(id, nombre, apellido, sexo, fechaNacimiento, categoria, deuda, deportes);
            Federados.Add(federado);
            return federado;

        }




        public static bool ValidarExistenciaSocio(string nombre, string apellido)
        {
            
            foreach (Socio item in socios)
            {
                if (item.Nombre == nombre && item.Apellido==apellido)
                {
                    throw new PersonaRepetidaException($"El socio {apellido} ya esta anotado");
                }
            }
            return true;
        }


        public static bool ValidarExistenciaOperativo(string nombre, string apellido)
        {

            foreach (EmpleadoOperativo item in operativos)
            {
                if (item.Nombre == nombre && item.Apellido == apellido)
                {
                    throw new PersonaRepetidaException($"El empleado {item.Apellido} ya esta anotado");
                }
            }
            return true;
        }



        public static bool ValidarExistenciaFederado(string nombre, string apellido)
        {
            foreach (Federado item in federados)
            {
                if (item.Nombre == nombre && item.Apellido == apellido)
                {
                    throw new PersonaRepetidaException($"El federado {apellido} ya esta anotado");
                }
            }
            return true;
        }


        public static bool ValidarExistenciaDeportivo(string nombre, string apellido)
        {
            foreach (EmpleadoDeportivo item in deportivos)
            {
                if (item.Nombre == nombre && item.Apellido == apellido)
                {
                    throw new PersonaRepetidaException($"El federado {apellido} ya esta anotado");
                }
            }
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
        //public static bool agregarDeportivo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos)
        //{
        //    EmpleadoDeportivo deportivo = new EmpleadoDeportivo(nombre, apellido, sexo, fechaNacimiento, equipos);
        //    foreach (EmpleadoDeportivo item in Deportivos)
        //    {
        //        if (item == deportivo)
        //        {
        //            throw new ExPersonaRepetida($"El Empleado Deportivo {apellido} ya esta anotado");
        //        }
        //    }

        //    deportivos.Add(deportivo);
        //    return true;
        //}



        //public static bool agregarOpeprativo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        //{
        //    EmpleadoOperativo operativo = new EmpleadoOperativo(nombre, apellido, sexo, fechaNacimiento, area);
        //    foreach (EmpleadoOperativo item in Operativos)
        //    {
        //        if (item == operativo)
        //        {
        //            throw new ExPersonaRepetida($"El Empleado Operativo {apellido} ya esta anotado");
        //        }
        //    }

        //    operativos.Add(operativo);
        //    return true;
        //}

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
                    return aux.actualizarDatos(nombre, apellido, sexo, fechaNacimiento,categoria);
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
                        ret1=aux.actualizarDatos(nombre, apellido, sexo, fechaNacimiento, categoria);
                        ret2= federado.ValidarDeportes(deportes);
                        return ret1||ret2;

                    }
                }
            }
            catch (NoHayDeportesException)
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
                        ret1 = ((Persona)aux).actualizarDatos(nombre, apellido, sexo, fechaNacimiento);
                        ret2 = aux.validarEquipos(deportes);
                        return ret1 || ret2;

                    }
                }
            }
            catch (NoHayDeportesException)
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
                    return aux.actualizarDatos(nombre, apellido, sexo, fechaNacimiento, area);
                }
            }

            return false;
        }


        /// <summary>
        /// Busca al objeto pasado por parametro en la lista Operativos de la clase
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>EmpleadoOperativo o null</returns>
        public static EmpleadoOperativo buscarOperativo(Persona persona)
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
        public static EmpleadoDeportivo buscarDeportivo(Persona persona)
        {
            foreach (EmpleadoDeportivo item in Deportivos)
            {
                if (persona == (Persona)item)
                {
                    return item;
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
        public static string generarFactura(Socio socio, int montoIngresado)
        {
            return socio.escribirFactura(montoIngresado);

        }

        /// <summary>
        /// Buscar al socio en la lista socios de la clase y lo borra
        /// </summary>
        /// <param name="socio"></param>
        /// <returns>bool</returns>
        public static bool borrarSocio(Socio socio)
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
        public static bool borrarFederado(Federado federado)
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

        public static Equipo CrearEquipoPorId(int id)
        {
            if (id == 1)
            {
                return new Equipo((EDeporte)1, (ECategoria)1, Esexo.f);
            }
            else if (id == 2)
            {
                return new Equipo((EDeporte)2, (ECategoria)1, Esexo.f);
            }
            else if(id == 3)
            {
                return new Equipo((EDeporte)3, (ECategoria)1, Esexo.f);
            }
            else if(id == 4)
            {
                return new Equipo((EDeporte)1, (ECategoria)1, Esexo.m);
            }
            else if(id == 5)
            {
                return new Equipo((EDeporte)2, (ECategoria)1, Esexo.m);
            }
            else if(id == 6)
            {
                return new Equipo((EDeporte)3, (ECategoria)1, Esexo.m);
            }
            else if(id == 7)
            {
                return new Equipo((EDeporte)1, (ECategoria)2, Esexo.f);
            }
            else if(id == 8)
            {
                return new Equipo((EDeporte)2, (ECategoria)2, Esexo.f);
            }
            else if(id == 9)
            {
                return new Equipo((EDeporte)3, (ECategoria)2, Esexo.f);
            }
            else if (id == 10)
            {
                return new Equipo((EDeporte)1, (ECategoria)2, Esexo.m);
            }
            else if (id == 11)
            {
                return new Equipo((EDeporte)2, (ECategoria)2, Esexo.m);
            }
            else if(id == 12)
            {
                return new Equipo((EDeporte)3, (ECategoria)2, Esexo.m);
            }
            else if (id == 13)
            {
                return new Equipo((EDeporte)1, (ECategoria)3, Esexo.f);
            }
            else if (id == 14)
            {
                return new Equipo((EDeporte)2, (ECategoria)3, Esexo.f);
            }
            else if (id == 15)
            {
                return new Equipo((EDeporte)3, (ECategoria)3, Esexo.f);
            }
            else if (id == 16)
            {
                return new Equipo((EDeporte)1, (ECategoria)3, Esexo.m);
            }
            else if (id == 17)
            {
                return new Equipo((EDeporte)2, (ECategoria)3, Esexo.m);
            }
            else if (id == 18)
            {
                return new Equipo((EDeporte)3, (ECategoria)3, Esexo.m);
            }
            return null;
        }


        /// <summary>
        /// Crea los objetos iniciales y los agrega a la lista correspondiente.
        /// </summary>
        //private static void sociosIniciales()
        //{
        //    Socio socio4 = new Socio("Mariano", "Gomez", Esexo.m, new DateTime(2004, 4, 4), ECategoria.menores);
        //    Socio socio5 = new Socio("Emilia", "Kinga", Esexo.f, new DateTime(1963, 09, 01), ECategoria.mayores);
        //    Socio socio6 = new Socio("Julia", "Menga", Esexo.f, new DateTime(2000, 12, 21), ECategoria.juveniles);
        //    Socio socio7 = new Socio("Lucio", "Lunix", Esexo.m, new DateTime(1980, 12, 01), ECategoria.mayores);
        //    Socio socio8 = new Socio("Marcos", "Ludovico", Esexo.m, new DateTime(2010, 12, 21), ECategoria.menores);
        //    Socio socio9 = new Socio("Roberto", "Roman", Esexo.m, new DateTime(2005, 12, 21), ECategoria.juveniles);


        //    List<EDeporte> deportes1 = new List<EDeporte>();
        //    deportes1.Add(EDeporte.handball);
        //    deportes1.Add(EDeporte.futbol);

        //    List<EDeporte> deportes2 = new List<EDeporte>();
        //    deportes2.Add(EDeporte.voley);

        //    List<EDeporte> deportes3 = new List<EDeporte>();
        //    deportes3.Add(EDeporte.handball);
        //    deportes3.Add(EDeporte.basket);

        //    Federado federado1 = new Federado("Francisco", "Henaren", Esexo.m, new DateTime(2000, 12, 21), ECategoria.juveniles, deportes1);
        //    Federado federado2 = new Federado("Nicolas", "Sazz", Esexo.m, new DateTime(1987, 04, 21), ECategoria.mayores, deportes2);
        //    Federado federado3 = new Federado("Matilda", "Monte", Esexo.m, new DateTime(1980, 03, 21), ECategoria.mayores, deportes3);

        //    Equipo equipo1 = new Equipo(ECategoria.menores, EDeporte.handball, Esexo.m);
        //    Equipo equipo2 = new Equipo(ECategoria.juveniles, EDeporte.handball, Esexo.m);
        //    Equipo equipo3 = new Equipo(ECategoria.juveniles, EDeporte.handball, Esexo.m);
        //    Equipo equipo4 = new Equipo(ECategoria.mayores, EDeporte.handball, Esexo.m);
        //    Equipo equipo5 = new Equipo(ECategoria.menores, EDeporte.handball, Esexo.m);
        //    Equipo equipo6 = new Equipo(ECategoria.mayores, EDeporte.handball, Esexo.m);
        //    Equipo equipo7 = new Equipo(ECategoria.menores, EDeporte.handball, Esexo.m);
        //    Equipo equipo8 = new Equipo(ECategoria.mayores, EDeporte.handball, Esexo.m);
        //    Equipo equipo69 = new Equipo(ECategoria.juveniles, EDeporte.handball, Esexo.m);



        //    List<Equipo> listEquipo1 = new List<Equipo>();
        //    listEquipo1.Add(equipo1);
        //    listEquipo1.Add(equipo2);
        //    listEquipo1.Add(equipo3);

        //    List<Equipo> listEquipo2 = new List<Equipo>();
        //    listEquipo2.Add(equipo4);
        //    listEquipo2.Add(equipo5);

        //    List<Equipo> listEquipo3 = new List<Equipo>();
        //    listEquipo3.Add(equipo6);

        //    EmpleadoDeportivo deportivo1 = new EmpleadoDeportivo("Mariano", "Martinez", Esexo.m, new DateTime(1987, 06, 21), listEquipo1);
        //    EmpleadoDeportivo deportivo2 = new EmpleadoDeportivo("Rosa", "Miriams", Esexo.f, new DateTime(1960, 05, 10), listEquipo2);
        //    EmpleadoDeportivo deportivo3 = new EmpleadoDeportivo("Jose", "Mexon", Esexo.m, new DateTime(1985, 07, 15), listEquipo3);



        //    socios.Add(socio4);
        //    socios.Add(socio5);
        //    socios.Add(socio6);
        //    socios.Add(socio7);
        //    socios.Add(socio8);
        //    socios.Add(socio9);

        //    federados.Add(federado1);
        //    federados.Add(federado2);
        //    federados.Add(federado3);

        //    deportivos.Add(deportivo1);
        //    deportivos.Add(deportivo2);
        //    deportivos.Add(deportivo3);

        //    //operativos.Add(operativo1);
        //    //operativos.Add(operativo2);
        //    //operativos.Add(operativo3);
        //    //operativos.Add(operativo4);
        //    //operativos.Add(operativo5);



        //}


        public static void TraerEquiposXml(string archivo)
        {

            List<Equipo> equiposNuevos = new List<Equipo>();
            Serializador<List<Equipo>> ser = new Serializador<List<Equipo>>(EtipoArchivoS.XML);

            if (eventoAviso is not null)
            {

                if (Club.Equipos.Count == CantidadEquipos)
                {
                    eventoAviso.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Equipos serializados ");

                }
                else
                {

                    eventoAviso.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Iniciando serializacion de equipos");
                    try
                    {
                        equiposNuevos = ser.Leer(archivo);
                        if (Club.Equipos.Count != 0)
                        {
                            Equipos.Clear();
                        }
                        Club.Equipos.AddRange(equiposNuevos);
                        //agrego que si ya estan cargados los equipos en club.equipos no serializo nada
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(6000);
                        eventoAviso.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: ERROR al serializar: {ex.Message}");
                    }
                    Thread.Sleep(6000);

                    eventoAviso.Invoke($"{ DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Serializacion finalizada con exito");
                }
                
            }


        }


        public static Task inicioTask(string archivo)
        {
            Task tarea = Task.Run(() => TraerEquiposXml(archivo));
            return tarea;
        }





    }
}
