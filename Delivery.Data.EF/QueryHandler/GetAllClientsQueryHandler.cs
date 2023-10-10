using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;

namespace Delivery.Data.EF.QueryHandler
{
    /// <summary>
    /// класс-запрос получения всех клиентов (грузополучателей, грузоотправителей)
    /// выполняет непосредственно запрос к БД через EF
    /// </summary>
    public class GetAllClientsQueryHandler : IQueryHandler<GetAllClientsQuery, GetAllClientsQueryModel>
    {
        private readonly DeliveryOrderDb _Context;
        public async Task<GetAllClientsQueryModel> ExecuteAsync(GetAllClientsQuery query)
        {
            IEnumerable<Client> clients = _Context.Clients;
            return new GetAllClientsQueryModel()
            {
                Clients = clients,
            };
        }
        public GetAllClientsQueryHandler(DeliveryOrderDb context)
        {
            _Context = context;
        }
    }
}

