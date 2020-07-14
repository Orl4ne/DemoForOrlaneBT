using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDbContext : IDisposable
    {
        EntityEntry Add(object entity);
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        void AddRange(params object[] entities);
        void AddRange(IEnumerable<object> entities);
        EntityEntry Attach(object entity);
        EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;
        void AttachRange(IEnumerable<object> entities);
        void AttachRange(params object[] entities);
        EntityEntry Entry(object entity);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        bool Equals(object obj);
        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;
        object Find(Type entityType, params object[] keyValues);
        EntityEntry Remove(object entity);
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        void RemoveRange(IEnumerable<object> entities);
        void RemoveRange(params object[] entities);
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry Update(object entity);
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
        void UpdateRange(IEnumerable<object> entities);
        void UpdateRange(params object[] entities);
    }
}
