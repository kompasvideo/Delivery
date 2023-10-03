using delivery.Models;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly InputHandler<OrderInputRequest, bool> _Handler; 

    public OrderController(InputHandler<OrderInputRequest, bool> handler)
    {
        _Handler = handler;
    }

    [HttpPost]
    [Route("/api/order/new")]
    public async Task<ActionResult> Add(OrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<object>(this, result);
    }
}

