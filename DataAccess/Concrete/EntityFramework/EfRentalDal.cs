using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, NewDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.UserId
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join cr in context.Cars
                             on r.CarId equals cr.Id
                             select new RentalDetailDto
                             {
                                 CarName = cr.CarName,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CompanyName = c.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();

            }
        }
    }
}
