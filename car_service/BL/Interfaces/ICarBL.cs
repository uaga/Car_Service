using car_service.DAL.Model;

namespace car_service.BL.Interfaces
{
    public interface ICarBL
    {
        bool AddNew(Car car);
        Car Get(int id);
        IEnumerable<Car> GetAll();
        IEnumerable<Car> GetCarsInWork();
    }
}
