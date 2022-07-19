using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class CustomerDal : GenericDal<Customer>, ICustomerDal
    {
        public List<Customer> GetCustomerListWithJob()
        {
            using (var c = new ProjectDb())
            {
                return c.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}