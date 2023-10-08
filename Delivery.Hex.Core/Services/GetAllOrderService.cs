using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Domain.Data;
using Delivery.Hex.Domain.Model;
using Delivery.Hex.Domain.Query;
using Delivery.Hex.Domain.Services;

namespace Delivery.Hex.Core;
public class GetAllOrderInputService : IGetAllOrderInputService
{
    private readonly IQueryHandler<GetAllQuery, GetAllQueryModel?> _Query;
    public GetAllOrderInputService(IQueryHandler<GetAllQuery, GetAllQueryModel?> query)
    {
        _Query = query;
    }
    public async Task<IEnumerable<object>> GetAllOrderAsync(GetAllOrderData data)
    {
        var model = await _Query.ExecuteAsync(new GetAllQuery());        
        return model.Orders;
    }    
}

