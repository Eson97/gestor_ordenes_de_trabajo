using BussinessLayer.Interfaces;
using BussinessLayer.Logger;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace BussinessLayer.UsesCases
{
    public class UsuarioController : IEntityManager<Usuario>
    {
        private static UsuarioController Instance;

        public static UsuarioController I
        {
            get
            {
                if (Instance == null) Instance = new UsuarioController();
                return Instance;
            }
        }

        public Usuario GetUser(string userName, string pass)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var element = db.Usuario.Where(el => el.Usuario1.Equals(userName) && el.Password.Equals(pass)).FirstOrDefault();
                    return element;
                }
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return null;
        }
        public Usuario Add(Usuario element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.Usuario.Add(element);
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
                    Usuario toDelete = db.Usuario.Find(id);
                    db.Usuario.Remove(toDelete);
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

        public Usuario Edit(Usuario element)
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

        public List<Usuario> GetLista()
        {
            List<Usuario> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    //TODO revisar campo
                    lista = db.Usuario.Include(el => el.UsuarioModulo).OrderBy(cp => cp.Usuario1).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<Usuario>();
        }
    }
}
