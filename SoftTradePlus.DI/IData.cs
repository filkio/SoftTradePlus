using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.DI
{
    public interface IData<T>
    {
        void Create(T item);
        void Update(T item, int id);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
