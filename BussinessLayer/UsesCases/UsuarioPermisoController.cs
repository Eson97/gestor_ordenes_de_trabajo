using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using DataLayer.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class UsuarioPermisoController : IEntityManager<UsuarioPermiso>
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


        public UsuarioPermiso Add(UsuarioPermiso element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var exist = db.UsuarioPermiso.Where(el => el.IdPermiso.Equals(element.IdPermiso) && el.IdUsuario.Equals(element.IdUsuario)).FirstOrDefault();
                    if (exist != null)
                        return exist;

                    element = db.UsuarioPermiso.Add(element);
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
                    UsuarioPermiso toDelete = db.UsuarioPermiso.Find(id);
                    db.UsuarioPermiso.Remove(toDelete);
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
        public bool DeleteByPermiso(UsuarioPermiso element)
        {
            if (element == null) return false;

            try
            {
                using (Entities db = new Entities())
                {
                    var toDelete = db.UsuarioPermiso.Where(el => el.IdPermiso.Equals(element.IdPermiso) && el.IdUsuario.Equals(element.IdUsuario)).FirstOrDefault();
                    db.UsuarioPermiso.Remove(toDelete);
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

        public IList<UsuarioPermiso> GetLista()
        {
            IList<UsuarioPermiso> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = true;
                    lista = db.UsuarioPermiso.Include(el => el.Permiso).Include(el => el.Usuario).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<UsuarioPermiso>();
        }
        public IList<Permiso> GetListaPermisoByUsuario(int IdUsuario)
        {
            IList<Permiso> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = true;
                    lista = db.UsuarioPermiso.Where(el => el.IdUsuario.Equals(IdUsuario)).Select(el => el.Permiso).ToList();
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
        public IList<Permiso> GetListaExcludePermisoByUsuario(int IdUsuario)
        {
            IList<Permiso> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    var todas = from p in db.Permiso
                                select p as Permiso;

                    var asignadas = from p in db.Permiso
                                    join up in db.UsuarioPermiso
                                    on p.Id equals up.IdPermiso
                                    where up.IdUsuario == IdUsuario
                                    select p as Permiso;

                    lista = todas.Except(asignadas).ToList();
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

        public UsuarioPermiso Edit(UsuarioPermiso element)
        {
            throw new NotImplementedException();
        }

    }
}
