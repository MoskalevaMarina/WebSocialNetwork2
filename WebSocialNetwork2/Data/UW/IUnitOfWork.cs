using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocialNetwork2.Data.Repositories;

namespace WebSocialNetwork2.Data.UW
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges(bool ensureAutoHistory = false);

        IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) where TEntity : class;
    }
}
