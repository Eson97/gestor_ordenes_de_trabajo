using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GestorOrdenesDeTrabajo.Enums;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class OrdenHistorialController : IEntityManager<OrdenHistorial>
    {
        private static OrdenHistorialController Instance;

        public static OrdenHistorialController I
        {
            get
            {
                if (Instance == null) Instance = new OrdenHistorialController();
                return Instance;
            }
        }

        public OrdenHistorial Add(OrdenHistorial element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenHistorial.Add(element);
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
        public OrdenHistorial GetOrdenById(int Id)
        {
            OrdenHistorial element;
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenHistorial.Find(Id);
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
                    OrdenHistorial toDelete = db.OrdenHistorial.Find(id);
                    db.OrdenHistorial.Remove(toDelete);
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

        public OrdenHistorial Edit(OrdenHistorial element)
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

        public List<OrdenHistorial> GetLista(OrdenStatus status)
        {
            List<OrdenHistorial> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = true;
                    lista = db.OrdenHistorial
                        .Where(el => el.Status == (int)status)
                        .AsNoTracking()
                        .ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<OrdenHistorial>();
        }

        public List<OrdenHistorial> GetLista()
        {
            List<OrdenHistorial> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.OrdenHistorial
                        .Include(el => el.Orden)
                        .AsNoTracking()
                        .ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<OrdenHistorial>();
        }
    }
}
