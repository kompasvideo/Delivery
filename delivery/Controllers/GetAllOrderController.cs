using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class GetAllOrderController : ControllerBase
    {
        private readonly InputHandler<GetAllOrderInputRequest, IEnumerable<object>> _Handler;
        public GetAllOrderController(InputHandler<GetAllOrderInputRequest, IEnumerable<object>> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/get_all")]
        public string GetAll()
        {
            var result = _Handler.HandleInput(new GetAllOrderInputRequest());
            string str = JsonConvert.SerializeObject(result.Result.Response);
            return str;
        }
    }
}
