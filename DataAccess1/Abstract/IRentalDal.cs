using Core.DataAccess;
using Entities.DTOs;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess1.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
      
        List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null);

    }
}

