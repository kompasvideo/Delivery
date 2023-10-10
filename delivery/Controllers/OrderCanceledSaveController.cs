using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class OrderCanceledSaveController : ControllerBase
    {
        private readonly InputHandler<OrderCanceledSaveInputRequest, bool> _Handler;
        public OrderCanceledSaveController(InputHandler<OrderCanceledSaveInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/order_canceled_save/{id}")]
        public void Get(int id, string comments)
        {
            _ = _Handler.HandleInput(new OrderCanceledSaveInputRequest()
            {
                Id = id,
                Comments = comments,
            });
        }
    }
}
