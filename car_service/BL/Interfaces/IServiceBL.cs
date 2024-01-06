using car_service.DAL.Model;

namespace car_service.BL.Interfaces
{
    public interface IServiceBL
    {
        bool AddNew(Service service);
        IEnumerable<Service> GetAll();
    }
}
