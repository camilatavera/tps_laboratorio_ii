using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibloteca;
using System.Collections.Generic;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class Federado_Test
    {

        [TestMethod]
        [ExpectedException(typeof(NoHayDeportesException))]
        public void ValidarDeportes_Test()
        {
            Federado federado = new Federado(100, "Milton", "Malkio", Esexo.m, new DateTime(01 / 01 / 1980), ECategoria.juveniles, 0);
            List<EDeporte> deportes = new List<EDeporte>();
            federado.ValidarDeportes(deportes);

        }



    }
}
