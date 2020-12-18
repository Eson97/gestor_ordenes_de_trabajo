using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class PermisoController : IEntityManager<Permiso>
    {
        private static PermisoController Instance;

        public static PermisoController I
        {
            get
            {
                if (Instance == null) Instance = new PermisoController();
                return Instance;
            }
        }

        public Permiso Add(Permiso element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.Permiso.Add(element);
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
                    Permiso toDelete = db.Permiso.Find(id);
                    db.Permiso.Remove(toDelete);
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

        public Permiso Edit(Permiso element)
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

        public List<Permiso> GetLista()
        {
            List<Permiso> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.Permiso
                        .AsNoTracking()
                        .OrderBy(cp => cp.Descripcion).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Permiso>();
        }
    }
}
