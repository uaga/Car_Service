using car_service.DAL.Interfaces;
using car_service.DAL.Model;
using Dapper;

namespace car_service.DAL.Implementations
{
    public class CustomerDAL : ICustomerDAL
    {
        public bool AddNew(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<Customer>("SELECT * FROM car_service.all_customers").ToList();
            }
        }
    }
}
