using System;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface IEditOrderInputService
	{
		Task<bool> EditOrderAsync(EditOrderData data);
	}
}

