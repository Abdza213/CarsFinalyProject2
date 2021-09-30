using _Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _Core.DataAccess
{
    public interface IEntityRepositoryDal<T> where T : class, IEntity, new()
    {
        void Add(T Item);
        void Delete(T Item);
        void Update(T Item);

        List<T> GetAll(Expression<Func<T, bool>> Filter = null);

        T GetById(Expression<Func<T, bool>> Filter);
    }
}
