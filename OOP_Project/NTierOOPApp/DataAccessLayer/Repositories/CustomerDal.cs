using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CustomerDal : GenericDal<Customer>, ICustomerDal
    {
    }
}