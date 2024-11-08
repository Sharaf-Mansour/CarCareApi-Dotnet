using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;
public static class CarClassController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/car-classes", async (IStorageBroker storageBroker) =>
        {
            var carClasses = await storageBroker.SelectAllCarClassesAsync();
            return Results.Ok(carClasses);
        })
            .Withname("GetCarClasses");

        app.MapGet("/car-classes/{carclassid}", async (IStorageBroker storageBroker, string carclassid) =>
        {
            var carClass = await storageBroker.SelectCarClassByidAsync(carclassid);
            return carClass is not null ? Results.Ok(carClass) : Results.NotFound();
        })
            .Withname("GetCarClassByid");

        app.MapPost("/car-classes", async (IStorageBroker storageBroker, CarClass carClass) =>
        {
            await storageBroker.InsertCarClassAsync(carClass);
            return Results.Created($"/car-classes/{carClass.id}", carClass);
        })
            .Withname("PostCarClass");

        app.MapPut("/car-classes/{carclassid}", async (IStorageBroker storageBroker, string carclassid, CarClass carClass) =>
        {
            carClass.id = carclassid;
            await storageBroker.UpdateCarClassAsync(carClass);
            return Results.NoContent();
        })
            .Withname("PutCarClass");

        app.MapDelete("/car-classes/{carclassid}", async (IStorageBroker storageBroker, string carclassid) =>
        {
            await storageBroker.DeleteCarClassAsync(carclassid);
            return Results.NoContent();
        })
            .Withname("DeleteCarClass");
    }
}
