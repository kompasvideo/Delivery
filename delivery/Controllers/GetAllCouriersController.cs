using Delivery.Hex.Drive.InputRequest;
using Delivery.Hex.Drive;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class GetAllCouriersController : ControllerBase
    {
        private readonly InputHandler<GetAllCouriersInputRequest, IEnumerable<object>> _Handler;

        [HttpGet]
        [Route("/api/order/get_all_couriers")]
        public IEnumerable<object> GetAllCouriers()
        {
            var result = _Handler.HandleInput(new GetAllCouriersInputRequest());
            return result.Result.Response;
        }

        public GetAllCouriersController(InputHandler<GetAllCouriersInputRequest, IEnumerable<object>> handler)
        {
            _Handler = handler;
        }
    }
}
