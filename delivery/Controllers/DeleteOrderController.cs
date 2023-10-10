using DeliveryServer.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers;

/// <summary>
/// Класс-контролёр удалить заявку по Id
/// </summary>
[ApiController]
public class DeleteOrderController : ControllerBase
{
    private readonly InputHandler<DeleteOrderInputRequest, bool> _Handler;

    public DeleteOrderController(InputHandler<DeleteOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    /// <summary>
    /// Удалить заявку по Id
    /// </summary>
    /// <param name="id">id заявки</param>
    /// <returns>результат удаления заявки</returns>
    /// <remarks>Удалить заявку по Id
    /// </remarks>
    /// <response code="200">результат удаления заявки - Ок</response>
    [HttpDelete]
    [Route("/api/order/delete/{id}")]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _Handler.HandleInput(new DeleteOrderInputRequest()
        {
            Id = id
        });
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

