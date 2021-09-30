using _Core.Utiletis;
using _Core.Utiletis.DataType;
using _Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _Businuse.Abstract
{
    public interface ICarServise
    {

        IResult Add(Cars Item);

        IDataResult<Cars> GetById(int Id);

        IDataResult<List<Cars>> GetAll(Expression<Func<Cars, bool>> Filter = null);
             

    }
}
