using car_service.DAL.Model;

namespace car_service.DAL.Interfaces
{
    public interface IServiceDAL
    {
        bool AddNew(Service service);
        IEnumerable<Service> GetAll();
    }
}
