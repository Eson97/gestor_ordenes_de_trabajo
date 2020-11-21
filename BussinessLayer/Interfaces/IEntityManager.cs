using System.Collections.Generic;

namespace BussinessLayer.Interfaces
{
    interface IEntityManager<T>
    {
        T Add(T element);
        T Edit(T element);
        bool Delete(int id);
        IList<T> GetLista();
    }
}
