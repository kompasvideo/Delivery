using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    public class GetAllClientsInputHandler : InputHandler<GetAllClientsInputRequest, IEnumerable<object>>
    {
        private readonly IGetAllClientsInputService _Service;
        public GetAllClientsInputHandler(IGetAllClientsInputService service)
        {
            _Service = service;
        }

        protected override IEnumerable<object> GetNullResult() => Enumerable.Empty<object>();

        protected override async Task<IEnumerable<object>> HandleRequest(GetAllClientsInputRequest request)
        {
            return await _Service.GetAllClientsAsync(request);
        }
    }
}

