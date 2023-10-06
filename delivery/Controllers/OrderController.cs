using delivery.Controllers.Extension;
using Delivery.Data.EF;
using Delivery.Data.EF.Entity.DeliveryOrder;
using Delivery.Hex.Drive;
using Delivery.Hex.Drive.InputRequest;
using Microsoft.AspNetCore.Mvc;

namespace delivery.Controllers;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly InputHandler<AddOrderInputRequest, bool> _Handler;
    private readonly DeliveryOrderDb context;

    //public OrderController(InputHandler<AddOrderInputRequest, bool> handler, DeliveryOrderDb ctx)
    public OrderController(DeliveryOrderDb ctx)
    {
        //_Handler = handler;
        context = ctx;
    }

    [HttpPost]
    [Route("/api/order/add")]
    //public async Task<ActionResult> Add(AddOrderInputRequest order)
    public void Add(AddOrderInputRequest order)
    {
        Order order1 = new Order();
        order1.OrderId = order.OrderId;
        order1.Date = order.Date;
        order1.Shipper = order.Shipper;
        order1.Consignee = order.Consignee;
        order1.Cargo = order.Cargo;
        order1.NewOrder = order.NewOrder;
        SaveOrder(order1);
        //var result = await _Handler.HandleInput(order);
        InputHandlerResponse<bool> result = null;
        return;
        //return ControllerBaseExtender.ReturnActionResultInputHandlerResponse<bool>(this, result);
    }

    [HttpGet]
    [Route("/api/order/get_all")]
    public IQueryable<Order> GetAll() 
    { 
        return GetOrders();
    }

    [HttpGet]
    [Route("/api/order/search")]
    public IEnumerable<Order> Search(string text)
    {
        return SearchOrder(text);
    }

    [HttpGet]
    [Route("/api/order/get/{id}")]
    public Order Get(int id = 1)
    {
        return GetOrderById(id);
    }

    [HttpPost]
    [Route("/api/order/edit")]
    public void Edit(AddOrderInputRequest order)
    {
        Order order1 = new Order();
        order1.OrderId = order.OrderId;
        order1.Date = order.Date;
        order1.Shipper = order.Shipper;
        order1.Consignee = order.Consignee;
        order1.Cargo = order.Cargo;
        order1.NewOrder = order.NewOrder;
        EditOrder(order1);
    }

    [HttpGet]
    [Route("/api/order/delete/{id}")]
    public void Delete(int id)
    {
        DeleteOrder(id);
    }



    private void SaveOrder(Order order)
    {
        if (order.OrderId == 0)
        {
            order.NewOrder = true;
            context.Orders.Add(order);
        }
        else
        {
            Order dbEntry = context.Orders.FirstOrDefault(p => p.OrderId == order.OrderId);
            if (dbEntry != null)
            {
                dbEntry.Shipper = order.Shipper;
                dbEntry.Cargo = order.Cargo;
                dbEntry.Consignee = order.Consignee;
                dbEntry.Date = order.Date;
                dbEntry.NewOrder = true;
            }
        }
        context.SaveChanges();
    }

    private IQueryable<Order> GetOrders() 
    { 
        return context.Orders;
    }

    private IEnumerable<Order> SearchOrder(string text)
    {
        List<Order> orders = context.Orders.ToList();
        IEnumerable<Order> res = from order in orders
                                 where order.Shipper.ToLower().Contains(text.ToLower())
                                    || order.Consignee.ToLower().Contains(text.ToLower())
                                    || order.Cargo.ToLower().Contains(text.ToLower())
                                 select order;
        return res;
    }

    private Order GetOrderById(int id)
    {
        Order order = context.Orders.FirstOrDefault(o => o.OrderId == id);
        return order;
    }
    private void EditOrder(Order order)
    {
        Order orderEdit = context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
        orderEdit.Date = order.Date;
        orderEdit.Shipper = order.Shipper;
        orderEdit.Consignee = order.Consignee;
        orderEdit.Cargo = order.Cargo;
        context.SaveChanges();
    }

    private void DeleteOrder(int id)
    {
        Order order = context.Orders.FirstOrDefault(p => p.OrderId == id);
        if (order != null)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}

