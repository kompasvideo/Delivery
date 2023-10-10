using Delivery.Hex.Domain.Model;

namespace Delivery.Hex.Domain.Query
{
    /// <summary>
    /// Данные для класса-запроса поиск текста в полях заявки
    /// </summary>
    public class SearchOrderQuery : IQuery<SearchOrderQueryModel>
    {
        public string Text { get; set; }
    }
}
