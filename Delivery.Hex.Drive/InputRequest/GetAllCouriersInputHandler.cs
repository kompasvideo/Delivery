using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// Класс для вызова класса-сервиса для получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    public class GetAllCouriersInputHandler : InputHandler<GetAllCouriersInputRequest, IEnumerable<object>>
    {
        private readonly IGetAllCouriersInputService _Service;
        public GetAllCouriersInputHandler(IGetAllCouriersInputService service)
        {
            _Service = service;
        }

        protected override IEnumerable<object> GetNullResult() => Enumerable.Empty<object>();

        protected override async Task<IEnumerable<object>> HandleRequest(GetAllCouriersInputRequest request)
        {
            return await _Service.GetAllCouriersAsync(request);
        }
    }
}

