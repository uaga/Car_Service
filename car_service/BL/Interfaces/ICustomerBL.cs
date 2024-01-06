using car_service.DAL.Model;

namespace car_service.BL.Interfaces
{
    public interface ICustomerBL
    {
        bool AddNew(Customer customer);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
    }
}
