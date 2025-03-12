using PDV_API.Models;

namespace PDV_API.Repository.Interfaces
{
    public interface IOrderRepository
    {
        List<OrderModel> FindAllOrders();
        OrderModel CreateOrder(OrderModel order);
        bool DeleteOrder(int id);
    }
}
