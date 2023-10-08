using Delivery.Hex.Drive.InputRequest;
using Delivery.Hex.Drive;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class GetAllClientsController : ControllerBase
    {
        private readonly InputHandler<GetAllClientsInputRequest, IEnumerable<object>> _Handler;

        [HttpGet]
        [Route("/api/order/get_all_clients")]
        public IEnumerable<object> GetAllClients()
        {
            var result = _Handler.HandleInput(new GetAllClientsInputRequest());
            return result.Result.Response;
        }

        public GetAllClientsController(InputHandler<GetAllClientsInputRequest, IEnumerable<object>> handler)
        {
            _Handler = handler;
        }
    }
}
