using car_service.BL.Interfaces;
using car_service.DAL.Interfaces;
using car_service.DAL.Model;

namespace car_service.BL.Implementations
{
    public class CarBL : ICarBL
    {
        private readonly ICarDAL carDAL;
        public CarBL(ICarDAL carDAL)
        {
            this.carDAL = carDAL;
        }

        public bool AddNew(Car car)
        {
            return carDAL.AddNew(car);
        }

        public Car Get(int id)
        {
            return carDAL.Get(id);
        }

        public IEnumerable<Car> GetAll()
        {
            return carDAL.GetAll();
        }

        public IEnumerable<Car> GetCarsInWork()
        {
            throw new NotImplementedException();
        }
    }
}
