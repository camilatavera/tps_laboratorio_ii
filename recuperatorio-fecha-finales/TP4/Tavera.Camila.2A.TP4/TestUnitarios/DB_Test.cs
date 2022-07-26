using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibloteca;
using System.Collections.Generic;
using System;
using ManejoDB;

namespace TestUnitarios
{
    [TestClass]
    public class DB_Test
    {


        [TestMethod]
        public void ValidarCupoEquipo_Test()
        {
            Equipo equipo = new Equipo(ECategoria.mayores, EDeporte.futbol, Esexo.f);
            bool ret=DB.ValidarCupoEquipo(equipo);
            Assert.IsTrue(ret);
           
        }

       



    }
}
