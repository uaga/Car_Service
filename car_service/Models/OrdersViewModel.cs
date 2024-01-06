using car_service.DAL.Model;

namespace car_service.Models
{
    public class OrdersViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
