using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
    }
}
