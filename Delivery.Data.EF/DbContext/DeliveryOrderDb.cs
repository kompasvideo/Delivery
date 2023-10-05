using Delivery.Data.EF.Entity.DeliveryOrder;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.EF;

public class DeliveryOrderDb : DbContext
{
    public DbSet<Order> Orders { get; set; }

    public DeliveryOrderDb(DbContextOptions<DeliveryOrderDb> options) : base(options)
    {

    }
}

