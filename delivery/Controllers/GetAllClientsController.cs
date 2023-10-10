using Delivery.Hex.Drive.InputRequest;
using Delivery.Hex.Drive;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    [ApiController]
    public class GetAllClientsController : ControllerBase
    {
        private readonly InputHandler<GetAllClientsInputRequest, IEnumerable<object>> _Handler;

        /// <summary>
        /// Получить всех клиентов (грузополучателей, грузоотправителей)
        /// </summary>
        /// <returns>все клиенты</returns>
        /// <remarks>Получить всех клиентов (грузополучателей, грузоотправителей)
        /// </remarks>
        /// <response code="200">все клиенты</response>
        [HttpGet]
        [Route("/api/order/get_all_clients")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
