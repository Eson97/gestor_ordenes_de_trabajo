using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using DataLayer.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GestorOrdenesDeTrabajo.UsesCases
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
                using (Entities db = new Entities())
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
                using (Entities db = new Entities())
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

        public IList<Orden> GetLista(int status)
        {
            List<Orden> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = true;
                    lista = db.Orden.Where(el => el.Status == status).OrderBy(cp => cp.Folio).Include(el => el.Cliente).ToList();
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

        public IList<Orden> GetLista()
        {
            IList<Orden> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.Orden.Include(el=>el.Cliente).OrderBy(cp => cp.Folio).ToList();
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

        public Orden SearchByFolio(int folio)
        {
            Orden orden;
            try
            {
                using (Entities db = new Entities())
                {
                    orden = db.Orden
                        .Include(el=>el.Cliente)
                        .Where(el => el.Folio.Equals(folio)).FirstOrDefault();
                }
                return orden;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
                return null;
            }
        }
    }
}
