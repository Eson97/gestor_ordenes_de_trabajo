using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BussinessLayer.UsesCases
{
    public class ModuloController : IEntityManager<Modulo>
    {
        public ModuloController()
        {
        }

        public Modulo Add(Modulo element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.Modulo.Add(element);
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
                    Modulo toDelete = db.Modulo.Find(id);
                    db.Modulo.Remove(toDelete);
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

        public Modulo Edit(Modulo element)
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

        public List<Modulo> GetLista()
        {
            List<Modulo> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.Modulo.OrderBy(cp => cp.Descripcion).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Modulo>();
        }
    }
}
