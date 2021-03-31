using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess1.Abstract;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess1.Concrete.EntityFramework.Repository
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentCarContext>, ICarImageDal
    {
    }
}
