using delivery.Controllers.Extension;
using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

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

