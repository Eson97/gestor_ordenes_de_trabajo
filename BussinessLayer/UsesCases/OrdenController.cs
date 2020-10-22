using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BussinessLayer.UsesCases
{
    public class OrdenController : IEntityManager<Orden>
    {
        private static OrdenController Instance;

        public static OrdenController I
        {
            get
            {
                if (Instance == null) Instance = new OrdenController();
                return Instance;
            }
        }

        public Orden Add(Orden element)
        {
            try
            {
                using (OrdenesDeTrabajoEntities db = new OrdenesDeTrabajoEntities())
                {
                    element = db.Orden.Add(element);
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
                using (OrdenesDeTrabajoEntities db = new OrdenesDeTrabajoEntities())
                {
                    Orden toDelete = db.Orden.Find(id);
                    db.Orden.Remove(toDelete);
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

        public Orden Edit(Orden element)
        {
            if (element.Id <= 0) return null;
            try
            {
                using (OrdenesDeTrabajoEntities db = new OrdenesDeTrabajoEntities())
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

        public List<Orden> GetLista()
        {
            List<Orden> lista = null;
            try
            {
                using (OrdenesDeTrabajoEntities db = new OrdenesDeTrabajoEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.Orden.OrderBy(cp => cp.Folio).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Orden>();
        }
    }
}
