using System.Collections.Generic;

namespace Third_Task.Service
{
    public interface IService<T>
    {
        void Create(T entity);

        void Update(T entity, long id);

        void Delete(long id);

        T Get(long id);

        IEnumerable<T> GetAll();
    }
}
