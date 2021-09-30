using _Core.DataAccess;
using _DataAccess.Abstract;
using _DataAccess.Context;
using _Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _DataAccess.Concrete
{
    class EfBrandDal : EntityRepositoryBaseDal<Brands, NorthWindContext>, IBrandDal
    {
    }
}
