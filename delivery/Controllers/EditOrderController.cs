using delivery.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

[ApiController]
public class EditOrderController : ControllerBase
{
    private readonly InputHandler<EditOrderInputRequest, bool> _Handler;

    public EditOrderController(InputHandler<EditOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    [HttpPost]
    [Route("/api/order/edit")]
    public async Task<ActionResult> Edit(EditOrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

