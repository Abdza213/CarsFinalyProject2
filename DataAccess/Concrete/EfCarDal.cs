using Core._DataAccess;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.NorthWind.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarDal : EntityRepositoryBase<Cars, NorthWindContext>,  ICarDal
    {
 
    }
}
