using Delivery.Hex.Drive.InputRequest;
using Delivery.Hex.Drive;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для получения всех курьеров
    /// </summary>
    [ApiController]
    public class GetAllCouriersController : ControllerBase
    {
        private readonly InputHandler<GetAllCouriersInputRequest, IEnumerable<object>> _Handler;

        /// <summary>
        /// Получить всех курьеров
        /// </summary>
        /// <returns>все курьеры</returns>
        /// <remarks>Получить всех курьеров
        /// </remarks>
        /// <response code="200">все курьеры</response>
        [HttpGet]
        [Route("/api/order/get_all_couriers")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
