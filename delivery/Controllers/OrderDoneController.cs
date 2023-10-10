using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для изменения статуса заявки как "Выполнено" 
    /// </summary>
    [ApiController]
    public class OrderDoneController : ControllerBase
    {
        private readonly InputHandler<OrderDoneInputRequest, bool> _Handler;
        public OrderDoneController(InputHandler<OrderDoneInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Изменить статус заявки на "Выполнено" 
        /// </summary>
        /// <remarks>Изменить статус заявки на "Выполнено" 
        /// </remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/api/order/order_done/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public void Get(int id)
        {
            _ = _Handler.HandleInput(new OrderDoneInputRequest()
            {
                Id = id,
            });
        }
    }
}
