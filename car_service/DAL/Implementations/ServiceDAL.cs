using car_service.DAL.Interfaces;
using car_service.DAL.Model;
using Dapper;

namespace car_service.DAL.Implementations
{
    public class ServiceDAL : IServiceDAL
    {
        public bool AddNew(Service service)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetAll()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<Service>("SELECT * FROM car_service.all_services").ToList();
            }
        }
    }
}
