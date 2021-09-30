using _Businuse.Abstract;
using _Businuse.Constants;
using _Core.Utiletis;
using _Core.Utiletis.DataType;
using _Core.Utiletis.FirstType;
using _DataAccess.Concrete;
using _DataAccess.Context;
using _Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace _Businuse.Concrete
{
    public class CarManeger : ICarServise
    {
        EfCarDal _car;

        public CarManeger(EfCarDal car)
        {
            _car = car;
        }

        public IResult Add(Cars Item)
        {
            if (Item.DailyPrice == 0)
            {
                return new ErrorResult(Message.CarPriceInvaild);
            }
            _car.Add(Item);
            return new SuccessResult(Message.CarAdded);
        }

        public IDataResult<List<Cars>> GetAll(Expression<Func<Cars, bool>> Filter = null)
        {
            if(DateTime.Now.Hour == 4)
            {
                return new ErrorDataResult<List<Cars>>(Message.CarNotInformation);
            }
            _car.GetAll(Filter);
            return new SuccessDataResult<List<Cars>>(_car.GetAll(Filter), Message.CarListed);
        }

        public IDataResult<Cars> GetById(int Id)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = context.Set<Cars>().SingleOrDefault(P => P.CarId == Id);
                if (result.CarId == Id)
                {
                    _car.GetById(P => P.CarId == Id);
                    return new SuccessDataResult<Cars>(_car.GetById(P => P.CarId == Id), Message.CarId);
                }
                else
                {
                    return new ErrorDataResult<Cars>(Message.CarNotInformation);
                }
            }

            
        }
    }
}
