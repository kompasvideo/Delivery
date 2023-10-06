using Delivery.Hex.Domain.Command;
using System;
namespace Delivery.Hex.Drive.InputRequest
{
	public class SearchOrderInputRequest: SearchOrderData, InputRequest<IEnumerable<object>>
	{        
    }
}

