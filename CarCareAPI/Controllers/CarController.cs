using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
using Microsoft.AspNetCore.Builder;

namespace CarCareAPI.Controllers;
public static class CarController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/cars", async (IStorageBroker storageBroker) =>
        {
            var cars = await storageBroker.SelectAllCarsAsync();
            return Results.Ok(cars);
        })
        .WithName("GetCars");

        app.MapGet("/cars/{carId}", async (IStorageBroker storageBroker, string carId) =>
        {
            var car = await storageBroker.SelectCarByIdAsync(carId);
            return car is not null ? Results.Ok(car) : Results.NotFound();
        })
        .WithName("GetCarById");

        app.MapPost("/cars", async (IStorageBroker storageBroker, Car car) =>
        {
            await storageBroker.InsertCarAsync(car);
            return Results.Created($"/cars/{car.id}", car);
        })
        .WithName("PostCar");

        app.MapPut("/cars/{carId}", async (IStorageBroker storageBroker, string carId, Car car) =>
        {
            car.id = carId;
            await storageBroker.UpdateCarAsync(car);
            return Results.NoContent();
        })
        .WithName("PutCar");

        app.MapDelete("/cars/{carId}", async (IStorageBroker storageBroker, string carId) =>
        {
            await storageBroker.DeleteCarAsync(carId);
            return Results.NoContent();
        })
        .WithName("DeleteCar");
    }
}