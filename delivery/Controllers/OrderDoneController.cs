using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class OrderDoneController : ControllerBase
    {
        private readonly InputHandler<OrderDoneInputRequest, bool> _Handler;
        public OrderDoneController(InputHandler<OrderDoneInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/order_done/{id}")]
        public void Get(int id)
        {
            _ = _Handler.HandleInput(new OrderDoneInputRequest()
            {
                Id = id,
            });
        }
    }
}
