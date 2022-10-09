using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace IMDBSWA.Core.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public int Add(TEntity entity)
        {
            using(TContext dbcontext = new TContext())
            {
                var addedEntity = dbcontext.Entry(entity);
                addedEntity.State = EntityState.Added;
                return dbcontext.SaveChanges();
            }
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includesPath = null)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includesPath = null)
        {
            using (TContext dbcontext = new TContext())
            {
                var query = dbcontext.Set<TEntity>().AsQueryable();
                if (filter != null) query = query.Where(filter);
                if (includesPath != null) query = includesPath(query);
                return query.ToList();
            }
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
