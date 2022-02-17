using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocialNetwork2.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
