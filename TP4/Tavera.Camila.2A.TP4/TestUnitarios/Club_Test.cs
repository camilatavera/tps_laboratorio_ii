using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibloteca;
using System.Collections.Generic;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class Club_Test
    {
        
        [TestMethod]
        public void buscarFederado_Test()
        {
            List<EDeporte> deportes1 = new List<EDeporte>();
            deportes1.Add(EDeporte.handball);
            deportes1.Add(EDeporte.futbol);
            Federado aux = new Federado(1, "Francisco", "Henaren", Esexo.m, new DateTime(2000, 12, 21), ECategoria.juveniles, deportes1);

            Federado ret = Club.buscarFederado(aux);

            Assert.IsNotNull(ret);
        }


        [TestMethod]
        public void updateSocio_Test()
        {
            Socio socio = new Socio(1, "Mariano", "Gomez", Esexo.m, new DateTime(2004, 4, 4), ECategoria.menores);

            bool ret=Club.UpdateSocio(socio, socio.Nombre, socio.Apellido, Esexo.f, socio.FechaNacimiento, ECategoria.menores);

            Assert.IsTrue(ret);

        }
    }
}
