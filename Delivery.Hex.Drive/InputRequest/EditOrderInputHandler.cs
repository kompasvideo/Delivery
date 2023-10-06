using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    public class EditOrderInputHandler : InputHandler<EditOrderInputRequest, bool>
	{
        private readonly IEditOrderInputService _Service;
		public EditOrderInputHandler(IEditOrderInputService service)
		{
            _Service = service;
		}

        protected override bool GetNullResult() => false;

        protected override async Task<bool> HandleRequest(EditOrderInputRequest request)
        {
            return await _Service.EditOrderAsync(request);
        }
    }
}

