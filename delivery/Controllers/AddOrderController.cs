using DeliveryServer.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers;

[ApiController]
public class AddOrderController : ControllerBase
{
    private readonly InputHandler<AddOrderInputRequest, bool> _Handler;

    public AddOrderController(InputHandler<AddOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    [HttpPost]
    [Route("/api/order/add")]
    public async Task<ActionResult> Add(AddOrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

