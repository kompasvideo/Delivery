using System;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface IDeleteOrderInputService
	{
		Task<bool> DeleteOrderAsync(DeleteOrderData data);
	}
}

