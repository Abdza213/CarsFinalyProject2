using Core._DataAccess;
using Core.Entites;
using Entites.Concrete;
using Entites.NorthWind.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepositoryDal<Brands>
    {
    }
}
