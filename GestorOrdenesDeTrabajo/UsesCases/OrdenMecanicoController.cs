using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.Auxiliares;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class OrdenMecanicoController : IEntityManager<OrdenMecanico>
    {
        private static OrdenMecanicoController Instance;

        public static OrdenMecanicoController I
        {
            get
            {
                if (Instance == null) Instance = new OrdenMecanicoController();
                return Instance;
            }
        }

        public OrdenMecanicoController()
        {
        }

        public OrdenMecanico Add(OrdenMecanico element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenMecanico.Add(element);
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
                    OrdenMecanico toDelete = db.OrdenMecanico.Find(id);
                    db.OrdenMecanico.Remove(toDelete);
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

        public List<MecanicoDTO> GetCountMecanicos(DateTime initDate, DateTime finDate)
        {
            List<MecanicoDTO> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    var list = db.OrdenMecanico
                        .AsNoTracking()
                        .Where(el => DbFunctions.TruncateTime(el.Orden.FechaEntrega) >= initDate.Date && DbFunctions.TruncateTime(el.Orden.FechaEntrega) <= finDate.Date
                        && el.Orden.Status == (int)OrdenStatus.ENTREGADA
                        || el.Orden.Status == (int)OrdenStatus.GARANTIA_POR_ENTREGAR
                        || el.Orden.Status == (int)OrdenStatus.GARANTIA_ENTREGADA)
                        .Select(el => el.Mecanico);

                    lista = list.Intersect(db.Mecanico)
                        .Select(el =>
                        new MecanicoDTO
                        {
                            Id = el.Id,
                        }).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            //Retorna lista vacia para evitar excepciones en llamada
            return new List<MecanicoDTO>();
        }

        public List<OrdenMecanicoDTO> GetListaBetween(DateTime initDate, DateTime finDate)
        {
            List<OrdenMecanicoDTO> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.OrdenMecanico
                        .AsNoTracking()
                        .Where(el => DbFunctions.TruncateTime(el.Orden.FechaEntrega) >= initDate.Date && DbFunctions.TruncateTime(el.Orden.FechaEntrega) <= finDate.Date
                        && el.Orden.Status == (int)OrdenStatus.ENTREGADA
                        || el.Orden.Status == (int)OrdenStatus.GARANTIA_POR_ENTREGAR
                        || el.Orden.Status == (int)OrdenStatus.GARANTIA_ENTREGADA)
                        .Select(el => new OrdenMecanicoDTO()
                        {
                            Id = el.Id,
                            CostoManoObra = el.CostoManoObra
                        })
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
            return new List<OrdenMecanicoDTO>();
        }

        public OrdenMecanico Edit(OrdenMecanico element)
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

        public List<OrdenMecanico> GetLista()
        {

            List<OrdenMecanico> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.OrdenMecanico
                        .Include(el => el.Mecanico)
                        .Include(el => el.Orden)
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
            return new List<OrdenMecanico>();
        }

        public OrdenMecanico GetByIdOrden(int idOrden)
        {
            if (idOrden <= 0) return null;
            OrdenMecanico element;
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenMecanico.Where(el => el.IdOrden.Equals(idOrden)).FirstOrDefault();
                }
                return element;
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return null;
        }

        public bool DeleteByOrden(int idOrden)
        {
            if (idOrden <= 0) return false;

            try
            {
                using (Entities db = new Entities())
                {
                    OrdenMecanico toDelete = db.OrdenMecanico
                        .Where(el => el.IdOrden.Equals(idOrden))
                        .FirstOrDefault();

                    db.OrdenMecanico.Remove(toDelete);
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
    }
}
