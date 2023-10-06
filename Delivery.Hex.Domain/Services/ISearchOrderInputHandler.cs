using System;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface ISearchOrderInputService
	{
		Task<IEnumerable<object>> SearchOrderAsync(SearchOrderData data);
	}
}

