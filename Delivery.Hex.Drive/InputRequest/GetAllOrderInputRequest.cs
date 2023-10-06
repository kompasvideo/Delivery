using Delivery.Hex.Domain.Command;
using System;
namespace Delivery.Hex.Drive.InputRequest
{
	public class GetAllOrderInputRequest: GetAllOrderData, InputRequest<IEnumerable<object>>
	{        
    }
}

