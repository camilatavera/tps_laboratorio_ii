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

        public void Buscar_Test()
        {
            EmpleadoOperativo operativo = new EmpleadoOperativo(100, "Michael", "Mixasd", Esexo.m, new DateTime(2004, 4, 4), EArea.administrativo);
            Club.Operativos.Add(operativo);
            EmpleadoOperativo aux = Club.BuscarOperativo((Persona)operativo);
            Assert.IsNotNull(aux);

        }



        [TestMethod]
        [ExpectedException(typeof(PersonaRepetidaException))]
        public void ValidarExistenciaOperativo_Test()
        {
            Club.Operativos.Add(new EmpleadoOperativo(100, "Michael", "Mixasd", Esexo.m, new DateTime(2004, 4, 4), EArea.administrativo));
            Club.ValidarExistenciaOperativo("Michael", "Mixasd");

        }
    }
}
