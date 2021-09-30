using Core._DataAccess;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.NorthWind.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfColorDal : EntityRepositoryBase<Colors, NorthWindContext>, IColorDal
    {

    }
}
