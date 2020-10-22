using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BussinessLayer.UsesCases
{
    public class MecanicoController : IEntityManager<Mecanico>
    {
        private static MecanicoController Instance;

        public static MecanicoController I
        {
            get
            {
                if (Instance == null) Instance = new MecanicoController();
                return Instance;
            }
        }

        public Mecanico Add(Mecanico element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.Mecanico.Add(element);
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
                    Mecanico toDelete = db.Mecanico.Find(id);
                    db.Mecanico.Remove(toDelete);
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

        public Mecanico Edit(Mecanico element)
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

        public List<Mecanico> GetLista()
        {
            List<Mecanico> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.Mecanico.OrderBy(cp => cp.Nombre).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Mecanico>();
        }
    }
}
