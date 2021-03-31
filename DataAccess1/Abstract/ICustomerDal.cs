using Core.DataAccess;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess1.Abstract
{
   public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
