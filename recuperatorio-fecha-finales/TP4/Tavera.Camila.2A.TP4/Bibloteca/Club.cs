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
        /// Valida que el socio este en la lista de socios y arroja una excepcion si ya existe
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        public static bool ValidarExistenciaSocio(string nombre, string apellido)
        {

            foreach (Socio item in socios)
            {
                if (item.Nombre == nombre && item.Apellido == apellido)
                {
                    throw new PersonaRepetidaException($"El socio {apellido} ya esta anotado");
                }
            }
            return true;
        }



        /// <summary>
        /// Valida que el operativo este en la lista correspondiente y arroja una excepcion si ya existe
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
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




        /// <summary>
        /// Valida que el federado este en la lista correspondiente y arroja una excepcion si ya existe
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
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



        /// <summary>
        /// Valida que el empleado deportivo este en la lista correspondiente y arroja una excepcion si ya existe
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
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
        /// autaliza los atributos del objeto si corresponde
        /// </summary>
        /// <param name="socio"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="categoria"></param>
        /// <returns>bool</returns>
        //public static bool UpdateSocio(Socio socio, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        //{
        //    Socio aux;
        //    for (int i = 0; i < Socios.Count; i++)
        //    {
        //        aux = socios[i];
        //        if (aux == socio)
        //        {
        //            return aux.ActualizarDatos(nombre, apellido, sexo, fechaNacimiento,categoria);
        //        }
        //    }

        //    return false;
        //}

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
        //public static bool UpdateFederado(Federado federado, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes)
        //{
        //    Federado aux;
        //    bool ret1;
        //    bool ret2;

        //    try
        //    {
        //        for (int i = 0; i < Federados.Count; i++)
        //        {
        //            aux = Federados[i];
        //            if (aux == federado)
        //            {
        //                ret1=aux.ActualizarDatos(nombre, apellido, sexo, fechaNacimiento, categoria);
        //                ret2= federado.ValidarDeportes(deportes);
        //                return ret1||ret2;

        //            }
        //        }
        //    }
        //    catch (NoHayDeportesException)
        //    {
        //        throw;
        //    }


        //    return false;          
        //}


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
        ////public static bool UpdateDeportivo(EmpleadoDeportivo deportivo, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> deportes)
        ////{

        ////    EmpleadoDeportivo aux;
        ////    bool ret1;
        ////    bool ret2;

        ////    try
        ////    {
        ////        for (int i = 0; i < Deportivos.Count; i++)
        ////        {
        ////            aux = Deportivos[i];
        ////            if (aux == deportivo)
        ////            {
        ////                ret1 = ((Persona)aux).ActualizarDatos(nombre, apellido, sexo, fechaNacimiento);
        ////                ret2 = aux.ValidarEquipos(deportes);
        ////                return ret1 || ret2;

        ////            }
        ////        }
        ////    }
        ////    catch (NoHayDeportesException)
        ////    {
        ////        throw;
        ////    }


        ////    return false;
        ////}


        ///// <summary>
        ///// autaliza los atributos del objeto si corresponde
        ///// </summary>
        ///// <param name = "operativo" ></ param >
        ///// < param name="nombre"></param>
        ///// <param name = "apellido" ></ param >
        ///// < param name="sexo"></param>
        ///// <param name = "fechaNacimiento" ></ param >
        ///// < param name="area"></param>
        ///// <returns>bool</returns>
        ////public static bool UpdateOperativo(EmpleadoOperativo operativo, string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, EArea area)
        ////{
        ////    EmpleadoOperativo aux;
        ////    for (int i = 0; i < Socios.Count; i++)
        ////    {
        ////        aux = operativos[i];
        ////        if (aux == operativo)
        ////        {
        ////            return aux.ActualizarDatos(nombre, apellido, sexo, fechaNacimiento, area);
        ////        }
        ////    }

        ////    return false;
        ////}


        /// <summary>
        /// Busca al objeto pasado por parametro en la lista Operativos de la clase
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>EmpleadoOperativo o null</returns>
        public static EmpleadoOperativo BuscarOperativo(Persona persona)
        {
            foreach (EmpleadoOperativo item in Operativos)
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
                    return item;
                }
            }
            return null;
        }

        public static bool BuscarSocio(Persona persona, out Socio socio)
        {
            foreach (Socio item in Socios)
            {
                if (persona == (Persona)item)
                {
                    socio = item;
                    return true;
                }
            }
            socio = null;
            return false;
        }



        public static bool BuscarFederado(Persona persona, out Federado federado)
        {
            foreach (Federado item in Federados)
            {
                if (persona == (Persona)item)
                {
                    federado = item;
                    return true;
                }
            }
            federado = null;
            return false;
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

        public static Task InicioTaskXml(string archivo)
        {
            Task tarea = Task.Run(() => TraerEquiposXml(archivo));
            return tarea;
        }



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
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(6000);
                        eventoAviso.Invoke($"{DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: ERROR al serializar \n {ex.Message}");
                    }
                    Thread.Sleep(6000);

                    eventoAviso.Invoke($"{ DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss")}: Serializacion finalizada con exito");
                }
                
            }


        }

        //public static bool validardepos(Federado federado, List<EDeporte> deportesNuevos)
        //{
        //    foreach (EDeporte item in deportesNuevos)
        //    {
        //        if (!federado.Deportes.Contains(item))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        





    }
}
