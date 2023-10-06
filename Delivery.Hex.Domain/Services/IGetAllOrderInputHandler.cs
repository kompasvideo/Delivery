using System;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface IGetAllOrderInputService
	{
		Task<IEnumerable<object>> GetAllOrderAsync(GetAllOrderData data);
	}
}

