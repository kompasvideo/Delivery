using DeliveryClient.Models;
using DeliveryClient.Models.Dtos;

namespace DeliveryClient.Mappers
{
    public interface IOrderMapper
    {
        OrderDto ToOrderDto(Order order);
        IEnumerable<OrderDto> ToOrderDto(IEnumerable<Order> orders);
    }
}
