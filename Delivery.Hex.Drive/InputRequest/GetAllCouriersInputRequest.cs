using Delivery.Hex.Domain.Entity;
namespace Delivery.Hex.Drive.InputRequest
{
    /// <summary>
    /// данные для класса для вызова класса-сервиса для получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    public class GetAllCouriersInputRequest : GetAllCouriersData, InputRequest<IEnumerable<object>>
    {
    }
}

