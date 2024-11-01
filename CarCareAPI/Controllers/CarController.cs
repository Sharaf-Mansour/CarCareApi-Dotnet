using CarCareAPI.Brokers.Storages;
using CarCareAPI.Models;
namespace CarCareAPI.Controllers;
public static class CarController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/cars", async (IStorageBroker storageBroker) =>
        {
            var cars = await storageBroker.SelectAllCars();
            return Results.Ok(cars);
        })
        .WithName("GetCars");

        app.MapGet("/cars/{carId}", async (IStorageBroker storageBroker, int carId) =>
        {
            var car = await storageBroker.SelectCarById(carId);
            return car is not null ? Results.Ok(car) : Results.NotFound();
        })
        .WithName("GetCarById");

        app.MapPost("/cars", async (IStorageBroker storageBroker, Car car) =>
        {
            await storageBroker.InsertCar(car);
            return Results.Created($"/cars/{car.Id}", car);
        })
        .WithName("PostCar");

        app.MapPut("/cars/{carId}", async (IStorageBroker storageBroker, string carId, Car car) =>
        {
            car.Id = carId;
            await storageBroker.UpdateCar(car);
            return Results.NoContent();
        })
        .WithName("PutCar");

        app.MapDelete("/cars/{carId}", async (IStorageBroker storageBroker, int carId) =>
        {
            await storageBroker.DeleteCar(carId);
            return Results.NoContent();
        })
        .WithName("DeleteCar");
    }
}
