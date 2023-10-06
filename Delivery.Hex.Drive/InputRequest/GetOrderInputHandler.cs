using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
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

