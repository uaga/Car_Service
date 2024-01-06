using car_service.DAL.Interfaces;
using car_service.DAL.Model;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Immutable;

namespace car_service.DAL.Implementations
{
    public class OrderDAL : IOrderDAL
    {
        public bool AddNew(int customer, int car, List<int> services)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                // вставка в Oreders
                connection.Query("INSERT INTO orders(car_id, customer_id) VALUES (@car, @customer)", 
                    new
                    {
                        car,
                        customer
                    }
                );
                var key_order = connection.Query<int>("select last_insert_id()");
                // вставка сервисов
                foreach (int key in services)
                {
                    connection.Query("insert into temp(val) values (@key)", new { key });
                }
                int key_order_int = key_order.First();
                connection.Query("call add_ordered_services(@key)", new { key = key_order_int });
                return true;
            }
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<Order>("SELECT * FROM car_service.view_orders").ToList();
            }
        }

        public IEnumerable<Order> GetOrdersInWork()
        {
            throw new NotImplementedException();
        }
    }
}
