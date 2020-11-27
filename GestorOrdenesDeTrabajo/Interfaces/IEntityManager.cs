using System.Collections.Generic;

namespace GestorOrdenesDeTrabajo.Interfaces
{
    interface IEntityManager<T>
    {
        T Add(T element);
        T Edit(T element);
        bool Delete(int id);
        List<T> GetLista();
    }
}
