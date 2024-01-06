using car_service.DAL.Model;

namespace car_service.DAL.Interfaces
{
    public interface IOrderDAL
    {
        bool AddNew(int customer, int car, List<int> services); 
        Order Get(int id);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetOrdersInWork();
    }
}
