using car_service.BL.Interfaces;
using car_service.DAL.Interfaces;
using car_service.DAL.Model;

namespace car_service.BL.Implementations
{
    public class CustomerBL : ICustomerBL
    {
        private readonly ICustomerDAL customerDAL;
        public CustomerBL(ICustomerDAL customerDAL)
        {
            this.customerDAL = customerDAL;
        }
        public bool AddNew(Customer customer)
        {
            return customerDAL.AddNew(customer);
        }

        public Customer Get(int id)
        {
            return customerDAL.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customerDAL.GetAll();
        }
    }
}
