using GestorOrdenesDeTrabajo.UsesCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestorOrdenesDeTrabajo.DB;
namespace UnitTesting
{
    [TestClass]
    public class ClienteControllerTest
    {
        [TestMethod]
        public void GetListaClienteCorrectamente()
        {
            var list = ClienteController.I.GetLista();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void EditClienteCorrectamente()
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
        public void EditClienteNullRetornaNull()
        {
            var c = ClienteController.I.Get(1);
            Assert.IsNotNull(c);

            c.Id = 0;
            var edited = ClienteController.I.Edit(c);
            Assert.IsNull(edited);

            edited = ClienteController.I.Edit(null);
            Assert.IsNull(edited);
        }

        [TestMethod]
        public void GetClienteNotFoundIsNull()
        {
            var c = ClienteController.I.Get(9889);
            Assert.IsNull(c);
        }

        [TestMethod]
        public void AddClienteNullReturnaNull()
        {
            var c = ClienteController.I.Add(null);
            Assert.IsNull(c);
        }

        [TestMethod]
        public void AddClienteCorrectamente()
        {
            var c = ClienteController.I.Add(new Cliente()
            {
                Nombre = "Prueba",
                Direccion = "Los reyes de salgado, Colonia Jardin,Calle las rosas #1233",
                Telefono = "3541022372"
            });

            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void EliminaClienteCorrectamente()
        {
            var c = ClienteController.I.Add(new Cliente()
            {
                Nombre = "Prueba",
                Direccion = "Los reyes de salgado, Colonia Jardin,Calle las rosas #1233",
                Telefono = "3541022372"
            });

            Assert.IsNotNull(c);

            bool deleted = ClienteController.I.Delete(c.Id);
            Assert.IsTrue(deleted);
        }
    }
}
