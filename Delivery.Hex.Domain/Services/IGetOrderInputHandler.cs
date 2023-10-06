using System;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface IGetOrderInputService
	{
		Task<object> GetOrderAsync(GetOrderData data);
	}
}

