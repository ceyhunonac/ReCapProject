using Entities1.Concrete;
using Entities1.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business1.Constants;
using Core.Utilities.Results;
using System.Linq.Expressions;


namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByCategoryId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);


    }
}
