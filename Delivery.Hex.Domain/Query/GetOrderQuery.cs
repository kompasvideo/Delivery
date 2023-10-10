using Delivery.Hex.Domain.Model;

namespace Delivery.Hex.Domain.Query
{
    /// <summary>
    /// Данные для класса-запроса получения заявки по Id
    /// </summary>
    public class GetOrderQuery : IQuery<GetOrderQueryModel>
    {
        public int Id { get; set; }
    }
}
