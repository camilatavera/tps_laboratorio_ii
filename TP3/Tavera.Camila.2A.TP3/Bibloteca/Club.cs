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

            sociosIniciales();

        }

        public static List<Socio> Socios
        {
            get { return socios; }
        }

        public static List<Federado> Federados
        {
            get { return federados; }
        }


        public static List<EmpleadoDeportivo> Deportivos
        {
            get { return deportivos; }
        }

        public static List<EmpleadoOperativo> Operativos
        {
            get { return operativos; }
        }


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

        public static bool agregarFederado(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria, List<EDeporte> deportes)
        {

            Federado nuevoFederado = new Federado(nombre, apellido, sexo, fechaNacimiento, categoria, deportes);
            foreach(Federado item in federados)
            {
                if (item == nuevoFederado)
                {
                    throw new ExPersonaRepetida($"El federado {apellido} ya esta anotado");
                }
            }

            federados.Add(nuevoFederado);
            return true;

        }

        public static bool agregarSocio(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, ECategoria categoria)
        {
           Socio socio = new Socio(nombre, apellido, sexo, fechaNacimiento, categoria);
            foreach (Socio item in socios)
            {
                if (item == socio)
                {
                    throw new ExPersonaRepetida($"El socio {apellido} ya esta anotado");
                }
            }

            socios.Add(socio);
            return true;

        }

        public static bool agregarDeportivo(string nombre, string apellido, Esexo sexo, DateTime fechaNacimiento, List<Equipo> equipos)
        {
            EmpleadoDeportivo deportivo = new EmpleadoDeportivo(nombre, apellido, sexo, fechaNacimiento, equipos);
            foreach (EmpleadoDeportivo item in Deportivos)
            {
                if (item == deportivo)
                {
                    throw new ExPersonaRepetida($"El Empleado Deportivo {apellido} ya esta anotado");
                }
            }

            deportivos.Add(deportivo);
            return true;
        }


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
                        ret2= federado.validarDeportes(deportes);
                        return ret1||ret2;

                    }
                }
            }
            catch (ExNoHayDeportes)
            {
                throw;
            }

            
            return false;          
        }



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
            catch (ExNoHayDeportes)
            {
                throw;
            }


            return false;
        }


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

        public static string generarFactura(Socio socio, int montoIngresado)
        {
            return socio.escribirFactura(montoIngresado);

        }

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

        private static void sociosIniciales()
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
            deportes2.Add(EDeporte.voley);

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

            EmpleadoDeportivo deportivo1 = new EmpleadoDeportivo("Mariano", "Martinez", Esexo.m, new DateTime(1987, 06, 21), listEquipo1);
            EmpleadoDeportivo deportivo2 = new EmpleadoDeportivo("Rosa", "Miriams", Esexo.f, new DateTime(1960, 05, 10), listEquipo2);
            EmpleadoDeportivo deportivo3 = new EmpleadoDeportivo("Jose", "Mexon", Esexo.m, new DateTime(1985, 07, 15), listEquipo3);

 

            socios.Add(socio4);
            socios.Add(socio5);
            socios.Add(socio6);
            socios.Add(socio7);
            socios.Add(socio8);
            socios.Add(socio9);

            federados.Add(federado1);
            federados.Add(federado2);
            federados.Add(federado3);

            deportivos.Add(deportivo1);
            deportivos.Add(deportivo2);
            deportivos.Add(deportivo3);

            //operativos.Add(operativo1);
            //operativos.Add(operativo2);
            //operativos.Add(operativo3);
            //operativos.Add(operativo4);
            //operativos.Add(operativo5);



        }





    }
}
