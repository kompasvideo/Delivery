using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// Класс для вызова класса-сервиса 
    /// </summary>
    public class TransferSaveOrderInputHandler : InputHandler<TransferSaveOrderInputRequest, bool>
	{
        private readonly ITransferSaveOrderInputService _Service;
		public TransferSaveOrderInputHandler(ITransferSaveOrderInputService service)
		{
            _Service = service;
		}

        protected override bool GetNullResult() => false;

        protected override async Task<bool> HandleRequest(TransferSaveOrderInputRequest request)
        {
            return await _Service.TransferSaveOrderAsync(request);
        }
    }
}

