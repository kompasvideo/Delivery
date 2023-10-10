using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Data.EF.QueryHandler
{
    /// <summary>
    /// класс-запрос получения всех клиентов (грузополучателей, грузоотправителей)
    /// выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class GetAllCouriersQueryHandler : IQueryHandler<GetAllCouriersQuery, GetAllCouriersQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<GetAllCouriersQueryModel> ExecuteAsync(GetAllCouriersQuery query)
        {
            IEnumerable<Courier> courier = _Context.Couriers;
            return new GetAllCouriersQueryModel()
            {
                Couriers = courier,
            };
        }
        public GetAllCouriersQueryHandler(DeliveryOrderDb context)
        {
            _Context = context;
        }
    }
}

