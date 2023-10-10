using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр получить Order по Id 
    /// </summary>
    [ApiController]
    public class GetOrderController : ControllerBase
    {
        private readonly InputHandler<GetOrderInputRequest, object> _Handler;
        public GetOrderController(InputHandler<GetOrderInputRequest, object> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Получить заявку по id
        /// </summary>
        /// <returns>заявка</returns>
        /// <remarks>Получить заявку по id
        /// </remarks>
        /// <response code="200">заявка</response>
        [HttpGet]
        [Route("/api/order/get/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string Get(int id = 1)
        {
            var result = _Handler.HandleInput(new GetOrderInputRequest()
            {
                Id = id
            });
            string str = JsonConvert.SerializeObject(result.Result.Response);
            return str;
        }
    }
}
