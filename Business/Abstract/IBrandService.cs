using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Delete(int brand);
        List<Brand> GetAllBrands();
        Brand GetBrandId(int brandId);
    }
}
