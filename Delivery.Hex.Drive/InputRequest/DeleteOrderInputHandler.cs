﻿using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Drive.InputRequest
{
    public class DeleteOrderInputHandler : InputHandler<DeleteOrderInputRequest, bool>
	{
        private readonly IDeleteOrderInputService _Service;
		public DeleteOrderInputHandler(IDeleteOrderInputService service)
		{
            _Service = service;
		}

        protected override bool GetNullResult() => false;

        protected override async Task<bool> HandleRequest(DeleteOrderInputRequest request)
        {
            return await _Service.DeleteOrderAsync(request);
        }
    }
}

