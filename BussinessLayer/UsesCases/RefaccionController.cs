﻿using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BussinessLayer.UsesCases
{
    class RefaccionController : IEntityManager<Refaccion>
    {
        private static RefaccionController Instance;

        public static RefaccionController I
        {
            get
            {
                if (Instance == null) Instance = new RefaccionController();
                return Instance;
            }
        }
        public Refaccion Add(Refaccion element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.Refaccion.Add(element);
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
                    Refaccion toDelete = db.Refaccion.Find(id);
                    db.Refaccion.Remove(toDelete);
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

        public Refaccion Edit(Refaccion element)
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

        public List<Refaccion> GetLista()
        {
            List<Refaccion> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.Refaccion.OrderBy(cp => cp.Descripcion).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Refaccion>();
        }
    }
}
