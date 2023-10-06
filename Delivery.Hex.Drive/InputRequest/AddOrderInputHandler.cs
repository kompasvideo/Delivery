using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    public class AddOrderInputHandler : InputHandler<AddOrderInputRequest, bool>
	{
        private readonly IAddOrderInputService _Service;
		public AddOrderInputHandler(IAddOrderInputService service)
		{
            _Service = service;
		}

        protected override bool GetNullResult() => false;

        protected override async Task<bool> HandleRequest(AddOrderInputRequest request)
        {
            return await _Service.AddOrderAsync(request);
        }
    }
}

