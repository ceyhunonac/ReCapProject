using Core.DataAccess.EntityFramework;

using DataAccess.Concrete.EntityFramework.Context;
using DataAccess1.Abstract;
using Entities1.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentCarContext>, IBrandDal
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}