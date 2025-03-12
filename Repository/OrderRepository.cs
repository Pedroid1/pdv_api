using PDV_API.Models;
using PDV_API.Repository.Interfaces;

namespace PDV_API.Repository;
public class OrderRepository : IOrderRepository
{
    private static List<OrderModel> _orders = new List<OrderModel>();
  
    private static int _idCounter = 1;

    public OrderModel CreateOrder(OrderModel order)
    {
        if (order == null)
        {
            throw new ArgumentNullException(nameof(order));
        }

        order.Id = _idCounter++;
        _orders.Add(order);

        return order;
    }

    public bool DeleteOrder(int id)
    {
        var orderToRemove = _orders.FirstOrDefault(order => order.Id == id);

        if (orderToRemove != null)
        {
            _orders.Remove(orderToRemove);
            return true;
        }

        return false;
    }

    public List<OrderModel> FindAllOrders()
    {
        return _orders;
    }
}
