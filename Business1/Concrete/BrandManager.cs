using Business.Abstract;
using Business1.Constants;
using Core.Utilities.Results;
using DataAccess1.Abstract;
using Entities1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdd);
            }
            return new ErrorResult(Messages.FailedBrandAddOrUpdate);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDelete);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(c => c.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.BrandUpdate);
            }
            return new ErrorResult(Messages.FailedBrandAddOrUpdate);
        }


    }
}