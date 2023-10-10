using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using DeliveryServer.Controllers.Extension;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для назначения курьера для заявки 
    /// </summary>
    [ApiController]
    public class TransferSaveOrderController : ControllerBase
    {
        private readonly InputHandler<TransferSaveOrderInputRequest, bool> _Handler;
        public TransferSaveOrderController(InputHandler<TransferSaveOrderInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Назначить заявке курьера
        /// </summary>
        /// <remarks>Назначить заявке курьера
        /// </remarks>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/api/order/transfer_save/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> TransferOrderSave(int id, string courier)
        {
            var result = await  _Handler.HandleInput(new TransferSaveOrderInputRequest()
            {
                Id = id,
                CourierName = courier,
            });
            return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
        }
    }
}
