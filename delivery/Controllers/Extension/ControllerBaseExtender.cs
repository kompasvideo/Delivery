using Delivery.Hex.Drive;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers.Extension
{
    public static class ControllerBaseExtender
    {
        public static ActionResult ReturnActionResultInputHandlerResponse<TResult>(ControllerBase controller, InputHandlerResponse<TResult> response)
        {

            if (!response.HasError)
            {
                return controller.Ok(response);
            }
            else
            {
                return controller.BadRequest(response);
            }
        }
    }
}
