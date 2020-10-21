using BussinessLayer.Interfaces;
//Las entidades se agregan desde Entities generadas por EF
using DataLayer.Auxiliares;
using System;
using System.Collections.Generic;

namespace BussinessLayer.UsesCases
{
    class ControlExample : IEntityManager<EntityExample>
    {
        private static ControlExample Instance;

        //TODO maybe add dependency injection for DB
        //private readonly Db db;
        //public ControlExample(Db db)
        //{
        //    this.db = db;
        //}

        public ControlExample()
        {
        }

        public static ControlExample I
        {
            get
            {
                if (Instance == null) Instance = new ControlExample();
                return Instance;
            }
        }

        public EntityExample Add(EntityExample element)
        {
            //try
            //{
            //    using (Db db = new Db())
            //    {
            //        var response= db.CategoriaProducto.Add(element);
            //        db.SaveChanges();
            //    }
            //    return response;
            //}
            //catch (Exception e)
            //{
            //    Log.Write("Ha ocurrido un error " + e.Message);
            //}
            //return null;

            throw new NotImplementedException();
        }

        public bool Delete(int idOtroNombre)
        {
            //if (categoria.id_categoria <= 0) return false;

            //try
            //{
            //    using (RestaurantEntities db = new RestaurantEntities())
            //    {
            //        categoria = db.CategoriaProducto.Find(categoria.id_categoria);
            //        //db.Entry(categoria).State = EntityState.Deleted;
            //        db.CategoriaProducto.Remove(categoria);
            //        db.SaveChanges();

            //    }
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    Log.Write("Ha ocurrido un error " + e.Message);
            //}
            //return false;

            throw new NotImplementedException();
        }

        public EntityExample Edit(EntityExample element)
        {
            //if (element.id_categoria <= 0) return null;
            //try
            //{
            //    using (RestaurantEntities db = new RestaurantEntities())
            //    {
            //        db.Entry(element.CategoriaProductoImagen).State = EntityState.Modified;
            //        db.Entry(element).State = EntityState.Modified;
            //        db.SaveChanges();
            //    }
            //    return element;
            //}
            //catch (Exception e)
            //{
            //    Log.Write("Ha ocurrido un error " + e.Message);
            //}
            //return null;

            throw new NotImplementedException();
        }

        public List<EntityExample> GetLista()
        {
            //List<CategoriaProducto> lista = null;
            //try
            //{
            //    using (RestaurantEntities db = new RestaurantEntities())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;
            //        lista = db.CategoriaProducto.OrderBy(cp => cp.nombre_categoria).ToList();
            //    }

            //    return lista;
            //}
            //catch (Exception e)
            //{
            //    string s = e.Message;
            //    Log.Write("Ha ocurrido un error " + s);
            //}
            //return new List<EntityExample>();

            throw new NotImplementedException();
        }
    }
}
