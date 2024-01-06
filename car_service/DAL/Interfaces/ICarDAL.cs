using car_service.DAL.Model;

namespace car_service.DAL.Interfaces
{
    public interface ICarDAL
    {
        bool AddNew(Car car);
        Car Get(int id);
        IEnumerable<Car> GetAll();
        IEnumerable<Car> GetCarInWork();
    }
}
