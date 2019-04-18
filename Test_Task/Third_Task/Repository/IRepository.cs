using System.Collections.Generic;
using Third_Task.Models;

namespace Third_Task.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);

        void Update(T entity, long id);

        void Delete(long id);

        T Get(long id);

        IEnumerable<T> GetAll();
    }
}
