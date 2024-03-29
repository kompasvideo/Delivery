﻿using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using DeliveryServer.Controllers.Extension;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliveryServer.Controllers
{
    /// <summary>
    /// Класс-контролёр для изменения статуса заявки как "Выполнено" 
    /// </summary>
    [ApiController]
    public class OrderDoneController : ControllerBase
    {
        private readonly InputHandler<OrderDoneInputRequest, bool> _Handler;
        public OrderDoneController(InputHandler<OrderDoneInputRequest, bool> handler)
        {
            _Handler = handler;
        }

        /// <summary>
        /// Изменить статус заявки на "Выполнено" 
        /// </summary>
        /// <remarks>Изменить статус заявки на "Выполнено" 
        /// </remarks>
        /// <response code="200"></response>
        [HttpPost]
        [Route("/api/order/order_done/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> OrderDone(int id)
        {
            var result = await _Handler.HandleInput(new OrderDoneInputRequest()
            {
                Id = id,
            });
            return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
        }
    }
}
