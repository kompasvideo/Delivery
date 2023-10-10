using DeliveryClient.Models;
using DeliveryClient.Models.Dtos;

namespace DeliveryClient.Mappers
{
    public class OrderMapper : IOrderMapper
    {
        public OrderDto ToOrderDto(Order order) 
        {
            OrderDto dto = new OrderDto()
            {
                OrderId = order.OrderId,
                Date = order.Date,
                ShipperInfoKey = order?.ShipperInfoKey ?? 0,
                ConsigneeInfoKey = order?.ConsigneeInfoKey ?? 0,
                Cargo = order.Cargo,
                StatusOrder = (int)order.StatusOrder,
                CourierInfoKey = order?.CourierInfoKey ?? 0,
                Comments = order.Comments,
            };
            if (order.Shipper != null)
            {
                dto.Shipper = order.Shipper.Name;
            }
            else dto.Shipper = null;
            if (order.Consignee != null)
            {
                dto.Consignee = order.Consignee.Name;
            }
            else dto.Consignee = null;
            if (order.Courier != null)
            {
                dto.Courier = order.Courier.Name;
            }
            else dto.Courier = null;
            return dto;
        }

        public IEnumerable<OrderDto> ToOrderDto(IEnumerable<Order> orders)
        {
            List<OrderDto> orderDtos = new List<OrderDto>();
            foreach (var order in orders) 
            { 
                orderDtos.Add(ToOrderDto(order));
            }
            return orderDtos;
        }
    }
}
