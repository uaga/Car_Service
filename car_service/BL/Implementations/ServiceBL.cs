using car_service.BL.Interfaces;
using car_service.DAL.Interfaces;
using car_service.DAL.Model;

namespace car_service.BL.Implementations
{
    public class ServiceBL : IServiceBL
    {
        private readonly IServiceDAL serviceDAL;
        public ServiceBL(IServiceDAL serviceDAL) 
        { 
            this.serviceDAL = serviceDAL;
        }
        public bool AddNew(Service service)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetAll()
        {
            return serviceDAL.GetAll();
        }
    }
}
