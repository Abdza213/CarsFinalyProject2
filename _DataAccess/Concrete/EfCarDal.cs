using _Core.DataAccess;
using _DataAccess.Abstract;
using _DataAccess.Context;
using _Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _DataAccess.Concrete
{
    public class EfCarDal : EntityRepositoryBaseDal<Cars, NorthWindContext>, ICarDal
    {

        
    }
}
