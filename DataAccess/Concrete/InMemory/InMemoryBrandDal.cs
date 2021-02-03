using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal:IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{ BrandId=1, BrandName="Mercedes"},
                new Brand{ BrandId=2, BrandName="Volkwagen"},
                new Brand{ BrandId=3, BrandName="Bmw"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(int brand)
        {
            Brand brandDelete = _brands.SingleOrDefault(b => b.BrandId == brand);
            _brands.Remove(brandDelete);
        }

        public List<Brand> GetAllBrands()
        {
            return _brands;
        }

        public Brand GetBrandId(int brandId)
        {
            return _brands.Where(b => b.BrandId == brandId).FirstOrDefault();
        }
    }
}
