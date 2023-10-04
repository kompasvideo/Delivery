using delivery.Controllers.Extension;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly InputHandler<AddOrderInputRequest, bool> _Handler; 

    public OrderController(InputHandler<AddOrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    [HttpPost]
    [Route("/api/order/new")]
    public async Task<ActionResult> Add(AddOrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }
}

