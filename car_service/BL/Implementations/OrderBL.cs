using car_service.BL.Interfaces;
using car_service.DAL.Interfaces;
using car_service.DAL.Model;

namespace car_service.BL.Implementations
{
    public class OrderBL : IOrderBL
    {
        private readonly IOrderDAL orderDAL;
        public OrderBL(IOrderDAL orderDAL)
        {
            this.orderDAL = orderDAL;
        }

        public bool AddNew(int customer, int car, List<int> services)
        {
            return this.orderDAL.AddNew(customer, car, services);
        }

        public Order Get(int id)
        {
            return orderDAL.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return orderDAL.GetAll();
        }

        public IEnumerable<Order> GetOrdersInWork()
        {
            return orderDAL.GetOrdersInWork();
        }
    }
}
