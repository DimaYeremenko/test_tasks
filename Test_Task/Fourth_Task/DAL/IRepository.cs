using System.Collections.Generic;

namespace Fourth_Task.DAL
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
