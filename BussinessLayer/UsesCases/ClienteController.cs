using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BussinessLayer.UsesCases
{
    public class ClienteController : IEntityManager<Cliente>
    {
        private static ClienteController Instance;

        public static ClienteController I
        {
            get
            {
                if (Instance == null) Instance = new ClienteController();
                return Instance;
            }
        }

        public Cliente Add(Cliente element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.Cliente.Add(element);
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
                    Cliente toDelete = db.Cliente.Find(id);
                    db.Cliente.Remove(toDelete);
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

        public Cliente Edit(Cliente element)
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

        public List<Cliente> GetLista()
        {
            List<Cliente> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.Cliente.OrderBy(cp => cp.Nombre).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Cliente>();
        }

    }
}
