using GestorOrdenesDeTrabajo.Interfaces;
using GestorOrdenesDeTrabajo.Logger;
using GestorOrdenesDeTrabajo.Auxiliares;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using GestorOrdenesDeTrabajo.Enums;
using System.Data.Entity;

namespace GestorOrdenesDeTrabajo.UsesCases
{
    public class OrdenRefaccionGarantiaController : IEntityManager<OrdenRefaccionGarantia>
    {
        private static OrdenRefaccionGarantiaController Instance;

        public static OrdenRefaccionGarantiaController I
        {
            get
            {
                if (Instance == null) Instance = new OrdenRefaccionGarantiaController();
                return Instance;
            }
        }

        public bool AddRange(List<OrdenRefaccionGarantia> elements, Orden orden)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.OrdenRefaccionGarantia.AddRange(elements);
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

        //TODO get Only necessary data and Add Status to Orden
        public List<RefaccionDTO> GetListaBetween(DateTime initDate, DateTime finDate)
        {
            List<RefaccionDTO> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.OrdenRefaccionGarantia
                        .AsNoTracking()
                        .Where(el => DbFunctions.TruncateTime(el.Orden.FechaEntrega) >= initDate.Date && DbFunctions.TruncateTime(el.Orden.FechaEntrega) <= finDate.Date
                        && el.Orden.Status.Equals(OrdenStatus.ENTREGADA))
                        .Select(el => new RefaccionDTO()
                        {
                            Id = el.Refaccion.Id,
                            //Descripcion = el.Refaccion.Descripcion,
                            //Codigo = el.Refaccion.Codigo,
                            //Cantidad = el.Cantidad,
                            //PrecioUnitrio = el.PrecioUnitario,
                            Total = el.PrecioUnitario * el.Cantidad
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
            return new List<RefaccionDTO>();
        }

        public OrdenRefaccionGarantia Add(OrdenRefaccionGarantia element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenRefaccionGarantia.Add(element);
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
        public List<OrdenRefaccionGarantia> Add(IEnumerable<OrdenRefaccionGarantia> element)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    element = db.OrdenRefaccionGarantia.AddRange(element);
                    db.SaveChanges();
                }
                return element.ToList();
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public bool DeleteRange(int idOrden)
        {
            if (idOrden <= 0) return false;

            try
            {
                using (Entities db = new Entities())
                {
                    db.OrdenRefaccionGarantia
                        .RemoveRange(db.OrdenRefaccionGarantia.Where(el => el.IdOrden.Equals(idOrden)));
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

        public OrdenRefaccionGarantia Edit(OrdenRefaccionGarantia element)
        {
            throw new NotImplementedException();
        }

        public List<OrdenRefaccionGarantia> GetLista()
        {
            throw new NotImplementedException();
        }

        public List<RefaccionDTO> GetListaByOrden(int IdOrden)
        {
            List<RefaccionDTO> lista = null;
            try
            {
                using (Entities db = new Entities())
                {
                    lista = db.OrdenRefaccionGarantia
                        .AsNoTracking()
                        .Where(el => el.IdOrden.Equals(IdOrden))
                        .Select(el => new RefaccionDTO()
                        {
                            Id = el.Refaccion.Id,
                            Descripcion = el.Refaccion.Descripcion,
                            Codigo = el.Refaccion.Codigo,
                            Cantidad = el.Cantidad,
                            PrecioUnitrio = el.PrecioUnitario,
                            Total = el.PrecioUnitario * el.Cantidad
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
            return new List<RefaccionDTO>();
        }
    }
}
