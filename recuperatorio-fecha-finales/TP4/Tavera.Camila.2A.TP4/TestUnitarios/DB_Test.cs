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
        public void DBAgregarFederado_Test()
        {
            //Socio Fe = new Socio(1, "Mariano", "Gomez", Esexo.m, new DateTime(2004, 4, 4), ECategoria.menores,0);

            //bool ret=Club.UpdateSocio(socio, socio.Nombre, socio.Apellido, Esexo.f, socio.FechaNacimiento, ECategoria.menores);

            //Assert.IsTrue(ret);
            List<EDeporte> deportesNuevos = new List<EDeporte>();
            deportesNuevos.Add(EDeporte.handball);
            deportesNuevos.Add(EDeporte.basket);

            bool ret=DB.AgregarFederado("Ruben", "Carlos", Esexo.m, new DateTime(2004, 4, 4), ECategoria.menores, 0, deportesNuevos);
            Assert.IsTrue(ret);

        }


        //[TestMethod]
        //public void validardepos_Test()
        //{
        //    List<EDeporte> deportes = new List<EDeporte>();
        //    deportes.Add(EDeporte.handball);
        //    deportes.Add(EDeporte.futbol);

        //    List<EDeporte> deportesNuevos = new List<EDeporte>();
        //    deportesNuevos.Add(EDeporte.handball);
        //    deportesNuevos.Add(EDeporte.basket);

        //    Federado federado= new Federado(1, "Mariano", "Gomez", Esexo.m, new DateTime(2004, 4, 4), ECategoria.menores, 0, deportes);

        //    bool ret = Club.validardepos(federado, deportesNuevos);

        //    Assert.IsFalse(ret);

        //}
    }
}
