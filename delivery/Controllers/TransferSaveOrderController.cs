using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class TransferSaveOrderController : ControllerBase
    {
        private readonly InputHandler<TransferSaveOrderInputRequest, bool> _Handler;
        public TransferSaveOrderController(InputHandler<TransferSaveOrderInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/transfer_save/{id}")]
        public void Get(int id, string courier)
        {
            _ = _Handler.HandleInput(new TransferSaveOrderInputRequest()
            {
                Id = id,
                CourierName = courier,
            });
        }
    }
}
