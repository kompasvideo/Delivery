﻿using System;
using Delivery.Hex.Domain.Command;

namespace Delivery.Hex.Domain.Services
{
	public interface IAddOrderInputService
	{
		Task<bool> AddOrderAsync(AddOrderData data);
	}
}

