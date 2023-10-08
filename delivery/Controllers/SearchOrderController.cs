using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    [ApiController]
    public class SearchOrderController : ControllerBase
    {
        private readonly InputHandler<SearchOrderInputRequest, IEnumerable<object>> _Handler;
        public SearchOrderController(InputHandler<SearchOrderInputRequest, IEnumerable<object>> handler)
        {
            _Handler = handler;
        }

        [HttpGet]
        [Route("/api/order/search")]
        public IEnumerable<object> Search(string text)
        {
            var result = _Handler.HandleInput(new SearchOrderInputRequest() 
            { 
                Text = text
            });
            return result.Result.Response;
        }
    }
}
