using System;
using System.Collections.Generic;
using GestorOrdenesDeTrabajo.UsesCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class Cliente
    {
        [TestMethod]
        public void GetListClienteCorrectamente()
        {
            var list = ClienteController.I.GetLista();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void EditaClienteCorrectamente()
        {
            var c = ClienteController.I.Get(1);
            Assert.IsNotNull(c);

            string antiguo = c.Nombre;
            string nuevo = "OtroNombre";
            c.Nombre = nuevo;

            var edited = ClienteController.I.Edit(c);

            Assert.IsNotNull(edited);
            Assert.AreNotEqual(antiguo, c.Nombre);
            Assert.AreEqual(c.Nombre, nuevo);

            c.Nombre = antiguo;
            ClienteController.I.Edit(c);
        }

        [TestMethod]
        public void NoEditaCliente()
        {
            var c = ClienteController.I.Get(1);
            Assert.IsNotNull(c);

            c.Id = 0;
            var edited = ClienteController.I.Edit(c);
            Assert.IsNull(edited);
        }
    }
}
