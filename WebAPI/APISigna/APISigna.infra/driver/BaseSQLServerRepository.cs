using APISigna.domain.Interfaces;
using APISigna.infra.Connection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.infra.Driver
{
    public class BaseSQLServerRepository : IDisposable
    {
        protected BaseSQLServer Db;

        protected BaseSQLServerRepository(BaseSQLServer context)
        {
            Db = context;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }

    public abstract class BaseSQLServerRepository<TEntity> : BaseSQLServerRepository, IBaseRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet;

        protected BaseSQLServerRepository(BaseSQLServer context) : base(context)
        {
            DbSet = Db.Set<TEntity>();
        }
        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }
        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }
        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
