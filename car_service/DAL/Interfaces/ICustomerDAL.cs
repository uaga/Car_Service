using car_service.DAL.Model;

namespace car_service.DAL.Interfaces
{
    public interface ICustomerDAL
    {
        bool AddNew(Customer customer);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
    }
}
