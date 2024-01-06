using car_service.DAL.Model;

namespace car_service.BL.Interfaces
{
    public interface IOrderBL
    {
        bool AddNew(int customer, int car, List<int> services);
        Order Get(int id);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetOrdersInWork();
    }
}
