﻿using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BussinessLayer.UsesCases
{
    public class UsuarioPermisoController : IEntityManager<UsuarioModulo>
    {
        private static UsuarioPermisoController Instance;
        public static UsuarioPermisoController I
        {
            get
            {
                if (Instance == null) return new UsuarioPermisoController();
                return Instance;
            }
        }
        public UsuarioPermisoController()
        {
        }


        public UsuarioModulo Add(UsuarioModulo element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.UsuarioModulo.Add(element);
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
                    UsuarioModulo toDelete = db.UsuarioModulo.Find(id);
                    db.UsuarioModulo.Remove(toDelete);
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

        public List<UsuarioModulo> GetLista()
        {
            List<UsuarioModulo> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = true;
                    lista = db.UsuarioModulo.Include(el => el.Modulo).Include(el => el.Usuario).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<UsuarioModulo>();
        }
        public List<Modulo> GetListaPermisoByUsuario(int IdUsuario)
        {
            List<Modulo> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = true;
                    lista = db.UsuarioModulo.Where(el => el.IdUsuario.Equals(IdUsuario)).Select(el => el.Modulo).ToList();
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

        public UsuarioModulo Edit(UsuarioModulo element)
        {
            throw new NotImplementedException();
        }

    }
}
