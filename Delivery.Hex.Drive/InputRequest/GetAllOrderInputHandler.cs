using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    public class GetAllOrderInputHandler : InputHandler<GetAllOrderInputRequest, IEnumerable<object>>
	{
        private readonly IGetAllOrderInputService _Service;
		public GetAllOrderInputHandler(IGetAllOrderInputService service)
		{
            _Service = service;
		}

        protected override IEnumerable<object> GetNullResult() => Enumerable.Empty<object>();

        protected override async Task<IEnumerable<object>> HandleRequest(GetAllOrderInputRequest request)
        {
            return await _Service.GetAllOrderAsync(request);
        }
    }
}

