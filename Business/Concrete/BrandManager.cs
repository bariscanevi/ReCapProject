using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal  _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(int brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAllBrands()
        {
            return _brandDal.GetAllBrands();
        }

        public Brand GetBrandId(int brandId)
        {
            return _brandDal.GetBrandId(brandId);
        }
    }
}
