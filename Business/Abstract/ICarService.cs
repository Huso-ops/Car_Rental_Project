using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
         IDataResult<Car> GetById(int carId);
         IDataResult <List<Car>> GetAll();
         IDataResult <List<Car>> GetAllByColorId(int colorId);
         IDataResult<List<Car>> GetAllByBrandId(int brandId);
         IDataResult <List<CarDetailDto>> GetCarDetails();
         IResult Add(Car car);
    }
}
