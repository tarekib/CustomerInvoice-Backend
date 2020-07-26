using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CustomerInvoicesApp.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        protected DbSet<TEntity> dbSet;

        public Repository(DbContext context)
        {
            Context = context;
            dbSet = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            dbSet.AddRange(entities);
        }

        public TEntity Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll(string [] children = null)
        {
            IQueryable<TEntity> query = dbSet;
            if(children != null)
            {
                foreach (string entity in children)
                {
                    query = query.Include(entity);
                }
            }
            return query.ToList();
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
