using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class OrdenMecanicoController : IEntityManager<OrdenMecanico>
    {
        private static OrdenMecanicoController Instance;

        public static OrdenMecanicoController I
        {
            get
            {
                if (Instance == null) Instance = new OrdenMecanicoController();
                return Instance;
            }
        }

        public OrdenMecanicoController()
        {
        }

        public OrdenMecanico Add(OrdenMecanico element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenMecanico.Add(element);
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
            if (id <= 0) return false;

            try
            {
                using (Entities db = new Entities())
                {
                    OrdenMecanico toDelete = db.OrdenMecanico.Find(id);
                    db.OrdenMecanico.Remove(toDelete);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return false;
        }

        public OrdenMecanico Edit(OrdenMecanico element)
        {
            if (element.Id <= 0) return null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(element).State = EntityState.Modified;
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

        public IList<OrdenMecanico> GetLista()
        {

            IList<OrdenMecanico> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.OrdenMecanico.Include(el => el.Mecanico).Include(el => el.Orden).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<OrdenMecanico>();
        }
    }
}
