using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepositoryDal<T> where T : IEntity, new()
    {

        void Add(T Item);

        void Delete(T Item);

        void Update(T Item);

        List<T> GetAll(Expression<Func<T, bool>> Filter = null);

        T GetById(int CarId);

    }
}
