using System;
using System.Collections.Generic;
using Bibloteca;
using ManejoArchivos;
using ManejoDB;

namespace p
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo(1, EDeporte.handball, ECategoria.menores, Esexo.f);
            Equipo equipo2 = new Equipo(2, EDeporte.handball, ECategoria.juveniles, Esexo.f);
            Equipo equipo3 = new Equipo(3, EDeporte.handball, ECategoria.mayores, Esexo.f);
            Equipo equipo4 = new Equipo(4, EDeporte.handball, ECategoria.menores, Esexo.m);
            Equipo equipo5 = new Equipo(5, EDeporte.handball, ECategoria.juveniles, Esexo.m);
            Equipo equipo6 = new Equipo(6, EDeporte.handball, ECategoria.mayores, Esexo.m);

            Equipo equipo7 = new Equipo(7, EDeporte.basket, ECategoria.menores, Esexo.f);
            Equipo equipo8 = new Equipo(8, EDeporte.basket, ECategoria.juveniles, Esexo.f);
            Equipo equipo9 = new Equipo(9, EDeporte.basket, ECategoria.mayores, Esexo.f);
            Equipo equipo10 = new Equipo(10, EDeporte.basket, ECategoria.menores, Esexo.m);
            Equipo equipo11 = new Equipo(11, EDeporte.basket, ECategoria.juveniles, Esexo.m);
            Equipo equipo12= new Equipo(12, EDeporte.basket, ECategoria.mayores, Esexo.m);

            Equipo equipo13 = new Equipo(13, EDeporte.futbol, ECategoria.menores, Esexo.f);
            Equipo equipo14 = new Equipo(14, EDeporte.futbol, ECategoria.juveniles, Esexo.f);
            Equipo equipo15 = new Equipo(15, EDeporte.futbol, ECategoria.mayores, Esexo.f);
            Equipo equipo16 = new Equipo(16, EDeporte.futbol, ECategoria.menores, Esexo.m);
            Equipo equipo17 = new Equipo(17, EDeporte.futbol, ECategoria.juveniles, Esexo.m);
            Equipo equipo18 = new Equipo(18, EDeporte.futbol, ECategoria.mayores, Esexo.m);

            List<Equipo> equipos = new List<Equipo>();
            equipos.Add(equipo1);
            equipos.Add(equipo2);
            equipos.Add(equipo3);
            equipos.Add(equipo4);
            equipos.Add(equipo5);
            equipos.Add(equipo6);
            equipos.Add(equipo7);
            equipos.Add(equipo8);
            equipos.Add(equipo9);
            equipos.Add(equipo10);
            equipos.Add(equipo11);
            equipos.Add(equipo12);
            equipos.Add(equipo13);
            equipos.Add(equipo14);
            equipos.Add(equipo15);
            equipos.Add(equipo16);
            equipos.Add(equipo17); 
            equipos.Add(equipo18);

            //string arch = AppDomain.CurrentDomain.BaseDirectory + "EquiposSerializados.xml";
            //Serializador<List<Equipo>> ser = new Serializador<List<Equipo>>(EtipoArchivoS.XML);

            //ser.Escribir(arch, equipos, true);

           // DB.agregarequipo(equipos);



        }
    }
}
