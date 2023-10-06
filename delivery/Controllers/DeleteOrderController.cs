using delivery.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

[ApiController]
public class DeleteOrderController : ControllerBase
{
    private readonly InputHandler<DeleteOrderInputRequest, bool> _Handler;

    public DeleteOrderController(InputHandler<DeleteOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    [HttpGet]
    [Route("/api/order/delete/{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _Handler.HandleInput(new DeleteOrderInputRequest()
        {
            Id = id
        });
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

