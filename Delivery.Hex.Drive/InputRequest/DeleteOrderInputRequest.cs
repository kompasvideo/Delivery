using Delivery.Hex.Domain.Command;
using System;
namespace Delivery.Hex.Drive.InputRequest
{
	public class DeleteOrderInputRequest: DeleteOrderData, InputRequest<bool>
	{        
    }
}

