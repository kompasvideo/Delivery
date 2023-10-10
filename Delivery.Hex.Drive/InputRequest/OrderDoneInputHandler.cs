using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// Класс для вызова класса-сервиса 
    /// </summary>
    public class OrderDoneInputHandler : InputHandler<OrderDoneInputRequest, bool>
	{
        private readonly IOrderDoneInputService _Service;
		public OrderDoneInputHandler(IOrderDoneInputService service)
		{
            _Service = service;
		}

        protected override bool GetNullResult() => false;

        protected override async Task<bool> HandleRequest(OrderDoneInputRequest request)
        {
            return await _Service.OrderDoneAsync(request);
        }
    }
}

