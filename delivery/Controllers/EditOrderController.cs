using DeliveryServer.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers;

/// <summary>
/// Класс-контролёр редактировать заявку
/// </summary>
[ApiController]
public class EditOrderController : ControllerBase
{
    private readonly InputHandler<EditOrderInputRequest, bool> _Handler;

    public EditOrderController(InputHandler<EditOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    /// <summary>
    /// Редактировать заявку
    /// </summary>
    /// <param name="order">отредактированные данные заявки</param>
    /// <returns>результат редактирования заявки</returns>
    /// <remarks>Редактировать заявку
    /// </remarks>
    /// <response code="200">результат редактирования заявки - Ок</response>
    [HttpPost]
    [Route("/api/order/edit")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> Edit(EditOrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

