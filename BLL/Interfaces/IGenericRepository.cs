using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        ICollection<T> GetCargoDtos();

        T GetById(int id);

        void Add(T model);

        void Update(T model);

        void RemoveById(int modelId);

        void RemoveAll(T model);
    }
}
