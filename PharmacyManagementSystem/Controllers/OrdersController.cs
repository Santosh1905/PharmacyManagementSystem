using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Dto;
using PharmacyManagementSystem.Repository;

namespace PharmacyManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepostiory _ordersRepository;

        public OrdersController(IOrdersRepostiory orderRepository)
        {
            _ordersRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var order = _ordersRepository.GetAll();
            return Ok(order);
        }
        [HttpPost]
        public IActionResult Post(AddOrders addOrder)
        {
            var order = new Order
            {
                OrderId = addOrder.OrderId,
                UserId = addOrder.UserId,
            };
            var newOrder = _ordersRepository.Create(order);
            return Created("Sucess", newOrder);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
            {
                throw new InvalidException("Invalid Id");
            }
            var order = _ordersRepository.GetOrders(id);
            if (order == null)
            {
                throw new InvalidException("Invalid Id");
            }
            return new OkObjectResult(order);
        }
    }

}