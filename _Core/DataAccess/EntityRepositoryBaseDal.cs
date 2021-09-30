using _Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace _Core.DataAccess
{
    public class EntityRepositoryBaseDal<TEntity, TContext> : IEntityRepositoryDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity Item)
        {
            using (TContext context = new TContext())
            {
                var AddItem = context.Entry(Item);
                AddItem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity Item)
        {
            using (TContext context = new TContext())
            {
                var DeleteItem = context.Entry(Item);
                DeleteItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity Item)
        {
            using (TContext context = new TContext())
            {
                var UpdateItem = context.Entry(Item);
                UpdateItem.State = EntityState.Unchanged;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> Filter = null)
        {
            using (TContext context = new TContext())
            {
                return Filter == null ?
                    context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(Filter).ToList();
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> Filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(Filter);
            }
        }
    }
}
