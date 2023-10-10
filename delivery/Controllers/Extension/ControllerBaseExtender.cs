using Delivery.Hex.Drive;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServer.Controllers.Extension
{
    /// <summary>
    /// класс для возврата результата запроса
    /// </summary>
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
