using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class RefaccionController : IEntityManager<Refaccion>
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


        public bool AddRange(List<Refaccion> elements)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Refaccion.AddRange(elements);
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

        /// <summary>
        /// Agrega el elemento si no existe, si existe actualiza los datos e isDeleted=false
        /// </summary>
        /// <param name="element"></param>
        /// <returns>el elemento con ID o null </returns>
        public Refaccion Add(Refaccion element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    Refaccion exist = db.Refaccion.Where(el => el.Codigo.Equals(element.Codigo)).FirstOrDefault();
                    if (exist == null)
                    { element = db.Refaccion.Add(element); }
                    else
                    {
                        exist.Codigo = element.Codigo;
                        exist.Descripcion = element.Descripcion;
                        exist.PrecioMinimo = element.PrecioMinimo;
                        exist.IsDeleted = false;
                        db.Entry(exist).State = EntityState.Modified;
                    }
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

        /// <summary>
        /// Actualiza isDeleted=true para eliminar
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool true si es eliminado</returns>
        public bool Delete(int id)
        {
            if (id <= 0) return false;

            try
            {
                using (Entities db = new Entities())
                {
                    bool isUsed = db.OrdenRefaccion.Any(el => el.IdRefaccion == id);
                    isUsed &= db.OrdenRefaccionGarantia.Any(el => el.IdRefaccion == id);
                    Refaccion toDelete = db.Refaccion.Find(id);
                    if (isUsed)
                    {
                        toDelete.IsDeleted = true;
                        db.Entry(toDelete).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Refaccion.Remove(toDelete);
                    }
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

        /// <summary>
        /// No edita el elemento si el codigo existe y no coincide con la refaccion
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Editada o null si el codigo existe</returns>
        public Refaccion Edit(Refaccion element)
        {
            if (element.Id <= 0) return null;
            try
            {
                using (Entities db = new Entities())
                {
                    var codeExist = db.Refaccion.Any(el => el.Codigo.Equals(element.Codigo) && el.Id != element.Id);
                    if (codeExist)
                        return null;
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

        /// <summary>
        /// No edita el elemento si el codigo existe y no coincide con la refaccion
        /// </summary>
        /// <param name="toEdit"></param>
        /// <returns>Editada o null si el codigo existe</returns>
        public Refaccion EditOnImport(Refaccion toEdit)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var codeExist = db.Refaccion.Any(el => el.Codigo.Equals(toEdit.Codigo));
                    if (!codeExist)
                        return null;
                    var element = db.Refaccion.Where(el => el.Codigo.Equals(toEdit.Codigo)).FirstOrDefault();

                    element.Descripcion = toEdit.Descripcion;
                    element.PrecioMinimo = toEdit.PrecioMinimo;
                    element.IsDeleted = false;
                    db.Entry(element).State = EntityState.Modified;
                    db.SaveChanges();
                    toEdit = element;
                }
                return toEdit;
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return null;
        }

        /// <summary>
        /// Consulta lista
        /// </summary>
        /// <returns>Retorna lista sin eliminados o lista vacia</returns>
        public List<Refaccion> GetLista()
        {
            List<Refaccion> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.Refaccion
                        .AsNoTracking()
                        .Where(el => !el.IsDeleted)
                        .OrderBy(cp => cp.Descripcion)
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
            return new List<Refaccion>();
        }

        public Dictionary<string, Refaccion> GetDictionary()
        {
            Dictionary<string, Refaccion> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    var refaccions = db.Refaccion
                        .Where(el => !el.IsDeleted)
                        .AsNoTracking()
                        .Select(
                        refaccion => new
                        {
                            refaccion.Codigo,
                            refaccion
                        });

                    lista = refaccions.ToDictionary(key => key.Codigo, el => el.refaccion);
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new Dictionary<string, Refaccion>();
        }

        public List<Refaccion> GetListaByOrden(int IdOrden)
        {
            List<Refaccion> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.OrdenRefaccion
                        .Where(el => el.IdOrden
                        .Equals(IdOrden))
                        .Select(el => el.Refaccion)
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
            return new List<Refaccion>();
        }
    }
}
