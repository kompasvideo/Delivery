namespace Delivery.Hex.Domain.Model
{
    /// <summary>
    /// выходные данные для класс-запроса получения всех клиентов (грузополучателей, грузоотправителей)
    /// </summary>
    public class GetAllCouriersQueryModel
    {
        public IEnumerable<object> Couriers { get; set; }
    }
}
