using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using DeliveryServer.Controllers.Extension;
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
        [HttpPost]
        [Route("/api/order/order_canceled_save/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> OrderCancelledSave(int id, string comments)
        {
            var result = await _Handler.HandleInput(new OrderCanceledSaveInputRequest()
            {
                Id = id,
                Comments = comments,
            });
            return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
        }
    }
}
