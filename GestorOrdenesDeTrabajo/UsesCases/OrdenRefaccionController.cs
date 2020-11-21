using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.Auxiliares;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class OrdenRefaccionController : IEntityManager<OrdenRefaccion>
    {
        private static OrdenRefaccionController Instance;

        public static OrdenRefaccionController I
        {
            get
            {
                if (Instance == null) Instance = new OrdenRefaccionController();
                return Instance;
            }
        }

        public OrdenRefaccion Add(OrdenRefaccion element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenRefaccion.Add(element);
                    db.SaveChanges();
                }
                return element;
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrdenRefaccion Edit(OrdenRefaccion element)
        {
            throw new NotImplementedException();
        }

        public IList<OrdenRefaccion> GetLista()
        {
            throw new NotImplementedException();
        }

        public IList<RefaccionDTO> GetListaByOrden(int IdOrden)
        {
            IList<RefaccionDTO> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.OrdenRefaccion.Where(el => el.IdOrden.Equals(IdOrden)).Select(el => new RefaccionDTO()
                    {
                        Id = el.Refaccion.Id,
                        Descripcion = el.Refaccion.Descripcion,
                        Cantidad = el.Cantidad,
                        Precio = el.PrecioUnitario,
                        Total = el.PrecioUnitario * el.Cantidad
                    }).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<RefaccionDTO>();
        }
    }
}
