using MySql.Data.MySqlClient;

namespace car_service.DAL.Implementations
{
    public class DBConnection
    {
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection("server=localhost;database=car_service;uid=car_service;pwd=car_service");
        }
    }
}
