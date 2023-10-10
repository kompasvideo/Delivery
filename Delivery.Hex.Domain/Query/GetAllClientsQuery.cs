using Delivery.Hex.Domain.Model;

namespace Delivery.Hex.Domain.Query
{
    /// <summary>
    /// Данные для класса-запроса получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    public class GetAllClientsQuery : IQuery<GetAllClientsQueryModel>
    {
    }
}
