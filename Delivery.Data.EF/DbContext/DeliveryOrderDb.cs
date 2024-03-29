﻿using Delivery.Data.EF.Entity.DeliveryOrder;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.EF;

/// <summary>
/// Контекст для БД DeliveryOrder
/// описывает все таблицы в БД и связи между ними
/// </summary>
public class DeliveryOrderDb : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Courier> Couriers { get; set; }

    public DeliveryOrderDb(DbContextOptions<DeliveryOrderDb> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasOne(u => u.Shipper)
            .WithMany(c => c.Order)
            .HasForeignKey(u => u.ShipperInfoKey)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Order>()
            .HasOne(u => u.Consignee)
            .WithMany(c => c.Order2)
            .HasForeignKey(u => u.ConsigneeInfoKey)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Order>()
            .HasOne(u => u.Courier)
            .WithMany(c => c.Order)
            .HasForeignKey(u => u.CourierInfoKey)
            .OnDelete(DeleteBehavior.Restrict);
    }
}