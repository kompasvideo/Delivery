using System;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface IAddOrderInputHandler
	{
		//Task<bool> AddOrderAsync(AddOrderInputRequest data);
		Task<bool> AddOrderAsync();
	}
}

