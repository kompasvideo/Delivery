using DeliveryServer.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers;

/// <summary>
/// Класс-контролёр зарегистрировать новую заявку
/// </summary>
[ApiController]
public class AddOrderController : ControllerBase
{
    private readonly InputHandler<AddOrderInputRequest, bool> _Handler;

    public AddOrderController(InputHandler<AddOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    /// <summary>
    /// Зарегистрировать новую заявку
    /// </summary>
    /// <param name="order">данные для новой заявки</param>
    /// <returns>результат регистрацииновой заявки</returns>
    /// <remarks>Зарегистрировать новую заявку
    /// </remarks>
    /// <response code="200">результат регистрацииновой заявки - Ок</response>
    [HttpPost]
    [Route("/api/order/add")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> AddOrder(AddOrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

