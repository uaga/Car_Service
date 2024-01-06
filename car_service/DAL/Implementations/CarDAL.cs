using car_service.DAL.Interfaces;
using car_service.DAL.Model;
using Dapper;

namespace car_service.DAL.Implementations
{
    public class CarDAL : ICarDAL
    {
        public bool AddNew(Car car)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                // Проверка на уникальность рег.номера и номера тех.паспорта
                try
                {
                    var q = connection.Query<bool>(
                        "call check_exist(@reg_num, @tech_num)", 
                        new { reg_num = car.RegNumber, tech_num = car.TechPassport }
                    );
                    if (!q.First())
                    {
                        connection.Query(
                        "call add_new_car(@brand, @model, @gen, @reg_num, @tech_num, @color, @release_date, @engine_num, @body_num)",
                        new { 
                            brand = car.Brand, 
                            model = car.Models, 
                            gen = car.Gen, 
                            reg_num = car.RegNumber, 
                            tech_num = car.TechPassport, 
                            color = car.Color, 
                            release_date = car.ReleaseDate, 
                            engine_num = car.EngineNumber, 
                            body_num = car.BodyNumber }
                        );
                        return true;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<Car>("SELECT * FROM car_service.all_cars").ToList();
            }
        }

        public IEnumerable<Car> GetCarInWork()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                throw new NotImplementedException();
            }
        }
    }
}
