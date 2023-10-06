using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers
{
    public class GetOrderController : ControllerBase
    {
        private readonly InputHandler<GetOrderInputRequest, object> _Handler;
        public GetOrderController(InputHandler<GetOrderInputRequest, object> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/get/{id}")]
        public Object Get(int id = 1)
        {
            var result = _Handler.HandleInput(new GetOrderInputRequest()
            {
                Id = id
            });
            return result.Result.Response;
        }
    }
}
