using Core.DataAccess;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities1.DTOs;
using System.Linq.Expressions;

namespace DataAccess1.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null);
    }
}
