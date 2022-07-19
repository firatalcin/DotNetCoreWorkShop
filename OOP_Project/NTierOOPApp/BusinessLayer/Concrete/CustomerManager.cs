using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer t)
        {
            _customerDal.Insert(t);
        }

        public Customer Get(int id)
        {
            return _customerDal.Get(id);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }

        public void Remove(Customer t)
        {
            _customerDal.Delete(t);
        }

        public void Update(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}