using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для поиска текста по заявкам 
    /// </summary>
    [ApiController]
    public class SearchOrderController : ControllerBase
    {
        private readonly InputHandler<SearchOrderInputRequest, IEnumerable<object>> _Handler;
        public SearchOrderController(InputHandler<SearchOrderInputRequest, IEnumerable<object>> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Искать текст во всех заявках
        /// </summary>
        /// <returns>список заявок</returns>
        /// <remarks>Искать текст во всех заявках
        /// </remarks>
        /// <response code="200">список заявок</response>
        [HttpGet]
        [Route("/api/order/search")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string Search(string text)
        {
            var result = _Handler.HandleInput(new SearchOrderInputRequest() 
            { 
                Text = text
            });
            return JsonConvert.SerializeObject(result.Result.Response);
        }
    }
}
