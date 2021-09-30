using _Core.DataAccess;
using _Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _DataAccess.Abstract
{
    public interface ICarDal : IEntityRepositoryDal<Cars> 
    {
    }
}
