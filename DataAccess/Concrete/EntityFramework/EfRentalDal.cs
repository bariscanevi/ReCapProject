using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from rental in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars
                             on rental.CarId equals car.CarId
                             join customer in context.Customers
                             on rental.CustomerId equals customer.UserId
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 CarId = car.CarId,
                                 CompanyName = customer.CompanyName,
                                 Description = car.Description,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate

                             };

                return result.ToList();
            }
        }
    }
}
