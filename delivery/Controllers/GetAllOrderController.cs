using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для получения всех заявок
    /// </summary>
    [ApiController]
    public class GetAllOrderController : ControllerBase
    {
        private readonly InputHandler<GetAllOrderInputRequest, IEnumerable<object>> _Handler;
        public GetAllOrderController(InputHandler<GetAllOrderInputRequest, IEnumerable<object>> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Получить все заказы
        /// </summary>
        /// <returns>все заказы</returns>
        /// <remarks>Получить все заказы 
        /// </remarks>
        /// <response code="200">все заказы</response>
        [HttpGet]
        [Route("/api/order/get_all")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string GetAll()
        {
            var result = _Handler.HandleInput(new GetAllOrderInputRequest());
            string str = JsonConvert.SerializeObject(result.Result.Response);
            return str;
        }
    }
}
