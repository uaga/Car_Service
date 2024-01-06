using car_service.DAL.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace car_service.Models
{
    public class AddOrderViewModel
    {
        public int Customer { get; set; }
        public int Car { get; set; }
        public List<int> Services { get; set; }
    }
}
