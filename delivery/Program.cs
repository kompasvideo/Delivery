﻿using DeliveryServer.Models;
using DeliveryServer.Startup;

namespace DeliveryServer;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.RegisterDatabaseContext(builder.Configuration);
        builder.Services.RegisterDeliveryServices(builder.Configuration);
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();

        SeedData.EnsurePopulated(app);
        app.MapControllers();

        app.Run();
    }
}

