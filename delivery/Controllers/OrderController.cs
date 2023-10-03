using delivery.Models;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly InputHandler<>

    public OrderController(ILogger<OrderController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("/api/order/new")]
    public async Task<ActionResult> Add(OrderInputRequest order)
    {
        var result = await _Handler.HandleInput(order);
        return null;
    }
}

