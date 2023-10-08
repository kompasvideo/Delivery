using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    public class GetAllOrderInputRequest : GetAllOrderData, InputRequest<IEnumerable<object>>
    {
    }
}

