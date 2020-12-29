using GestorOrdenesDeTrabajo.UsesCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestorOrdenesDeTrabajo.DB;
using System;
using GestorOrdenesDeTrabajo.Enums;

namespace UnitTesting
{
    [TestClass]
    public class OrdenControllerTest
    {
        [TestMethod]
        public void GetListaOrdenCorrectamente()
        {
            var list = OrdenController.I.GetLista();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void EditOrdenCorrectamente()
        {
            Orden c = OrdenController.I.Get(1);
            Assert.IsNotNull(c);

            int antiguo = c.Folio;
            int nuevo = 99999;
            c.Folio = nuevo;

            var edited = OrdenController.I.Edit(c);

            Assert.IsNotNull(edited);
            Assert.AreNotEqual(antiguo, c.Folio);
            Assert.AreEqual(c.Folio, nuevo);

            c.Folio = antiguo;
            edited = OrdenController.I.Edit(c);
            Assert.IsNotNull(edited);
        }

        [TestMethod]
        public void EditOrdenNullRetornaNull()
        {
            var c = OrdenController.I.Get(1);
            Assert.IsNotNull(c);

            c.Id = 0;
            var edited = OrdenController.I.Edit(c);
            Assert.IsNull(edited);

            edited = OrdenController.I.Edit(null);
            Assert.IsNull(edited);
        }

        [TestMethod]
        public void GetOrdenNotFoundIsNull()
        {
            var c = OrdenController.I.Get(9889);
            Assert.IsNull(c);
        }

        [TestMethod]
        public void AddOrdenNullReturnaNull()
        {
            var c = OrdenController.I.Add(null);
            Assert.IsNull(c);
        }

        [TestMethod]
        public void AddOrdenCorrectamente()
        {
            var c = OrdenController.I.Add(new Orden()
            {
                Equipo = "Motosierra Huskvarna Modelo 68",
                FechaRecepcion = DateTime.Now,
                FechaEntrega = DateTime.Now,
                Observaciones = "Mantenimiento General, Anillada a pistones, Cambiar la cadena para reparacion cliente abierto a una nueva",
                Referencia = "12343445435",
                IdCliente = 1,
                Folio = 98789,
                Status = (int)OrdenStatus.ESPERA,
                TipoPago = (int)TipoPago.EFECTIVO,
            });

            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void EliminaOrdenCorrectamente()
        {
            var c = OrdenController.I.Add(new Orden()
            {
                Equipo = "Motosierra Huskvarna Modelo 68",
                FechaRecepcion = DateTime.Now,
                FechaEntrega = DateTime.Now,
                Observaciones = "Mantenimiento General, Anillada a pistones, Cambiar la cadena para reparacion cliente abierto a una nueva",
                Referencia = "12343445435",
                IdCliente = 1,
                Folio = 98789,
                Status = (int)OrdenStatus.ESPERA,
                TipoPago = (int)TipoPago.EFECTIVO,
            });

            Assert.IsNotNull(c);

            bool deleted = OrdenController.I.Delete(c.Id);
            Assert.IsTrue(deleted);
        }
    }
}
