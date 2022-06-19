using System;
using System.Collections.Generic;
using Bibloteca;
using ManejoDB;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {


            //DB.AgregarSocio("Emilia", "Kinga", Esexo.f, new DateTime(1963, 09, 01), ECategoria.mayores, 1000);

            List<EDeporte> deportes3 = new List<EDeporte>();
            deportes3.Add(EDeporte.handball);

            //DB.AgregarFederado("Francisco", "Henaren", Esexo.m, new DateTime(2000, 12, 21), ECategoria.juveniles, 0, deportes3);


            //Console.WriteLine("hola");

            //List<Socio> socios = new List<Socio>();

            //socios = DB.TraerSocios();

            //foreach (Socio aux in socios)
            //{
            //    Console.WriteLine(aux.ToString());
            //}


            //List<Federado> federados = new List<Federado>();
            //federados = DB.TraerFederados();

            //foreach (Federado aux in federados)
            //{
            //    Console.WriteLine(aux);
            //    Console.Write(aux.devolverDeportes());



            //}


            Federado aux = DB.BuscarFederado("Camila", "Vazquez");
            DB.UpdateFederado(aux, "Camila", "Vazquez", Esexo.f, new DateTime(01 / 01 / 1900), ECategoria.juveniles, deportes3);

        }
    }
}
