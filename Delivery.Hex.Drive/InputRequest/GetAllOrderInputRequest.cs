using Delivery.Hex.Domain.Data;
namespace Delivery.Hex.Drive.InputRequest
{
    public class GetAllOrderInputRequest : GetAllOrderData, InputRequest<IEnumerable<object>>
    {
    }
}

