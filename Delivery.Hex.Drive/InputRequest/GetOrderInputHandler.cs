using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// Класс для вызова класса-сервиса для получения заявки по Id
    /// </summary>
    public class GetOrderInputHandler : InputHandler<GetOrderInputRequest, object>
    {
        private readonly IGetOrderInputService _Service;
        public GetOrderInputHandler(IGetOrderInputService service)
        {
            _Service = service;
        }

        protected override object GetNullResult() => new object();

        protected override async Task<object> HandleRequest(GetOrderInputRequest request)
        {
            return await _Service.GetOrderAsync(request);
        }
    }
}

