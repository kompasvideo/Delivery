using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// Класс для вызова класса-сервиса 
    /// </summary>
    public class OrderCanceledSaveInputHandler : InputHandler<OrderCanceledSaveInputRequest, bool>
	{
        private readonly IOrderCanceledSaveInputService _Service;
		public OrderCanceledSaveInputHandler(IOrderCanceledSaveInputService service)
		{
            _Service = service;
		}

        protected override bool GetNullResult() => false;

        protected override async Task<bool> HandleRequest(OrderCanceledSaveInputRequest request)
        {
            return await _Service.OrderCanceledSaveAsync(request);
        }
    }
}

