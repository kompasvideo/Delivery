using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для изменения статуса заявки как "Отменено" 
    /// </summary>
    [ApiController]
    public class OrderCanceledSaveController : ControllerBase
    {
        private readonly InputHandler<OrderCanceledSaveInputRequest, bool> _Handler;
        public OrderCanceledSaveController(InputHandler<OrderCanceledSaveInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Изменить статус заявки на "Отменено" 
        /// </summary>
        /// <remarks>Изменить статус заявки на "Отменено" 
        /// </remarks>
        /// <response code="200"></response>
        [HttpGet]
        [Route("/api/order/order_canceled_save/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
