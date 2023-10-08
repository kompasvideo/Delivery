using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public string Search(string text)
        {
            var result = _Handler.HandleInput(new SearchOrderInputRequest() 
            { 
                Text = text
            });
            string str = JsonConvert.SerializeObject(result.Result.Response);
            return str;
        }
    }
}
