using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV_API.Models;
using PDV_API.Repository.Interfaces;

namespace PDV_API.Controllers
{
    [Route("api/pedidos")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public ActionResult<List<OrderModel>> GetAllOrders()
        {
            return Ok(_orderRepository.FindAllOrders());
        }

        [HttpPost]
        public ActionResult<OrderModel> CreateOrder([FromBody] OrderModel order)
        {
            return Ok(_orderRepository.CreateOrder(order));
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteOrder(int id)
        {
            return Ok(_orderRepository.DeleteOrder(id));
        }
    }
}
