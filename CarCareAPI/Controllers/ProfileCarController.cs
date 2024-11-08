using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;

public static class ProfileCarController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/profile-cars", async (IStorageBroker storageBroker) =>
        {
            var profileCars = await storageBroker.SelectAllProfileCarsAsync();
            return Results.Ok(profileCars);
        })
        .Withname("GetProfileCars");

        app.MapGet("/profile-cars/{profilecarid}", async (IStorageBroker storageBroker, string profilecarid) =>
        {
            var profileCar = await storageBroker.SelectProfileCarByidAsync(profilecarid);
            return profileCar is not null ? Results.Ok(profileCar) : Results.NotFound();
        })
        .Withname("GetProfileCarByid");

        app.MapPost("/profile-cars", async (IStorageBroker storageBroker, ProfileCar profileCar) =>
        {
            await storageBroker.InsertProfileCarAsync(profileCar);
            return Results.Created($"/profile-cars/{profileCar.profileid}", profileCar);
        })
        .Withname("PostProfileCar");

        app.MapPut("/profile-cars/{profilecarid}", async (IStorageBroker storageBroker, string profilecarid, ProfileCar profileCar) =>
        {
            profileCar.carid = profilecarid;
            await storageBroker.UpdateProfileCarAsync(profileCar);
            return Results.NoContent();
        })
        .Withname("PutProfileCar");

        app.MapDelete("/profile-cars/{profilecarid}", async (IStorageBroker storageBroker, string profilecarid) =>
        {
            await storageBroker.DeleteProfileCarAsync(profilecarid);
            return Results.NoContent();
        })
        .Withname("DeleteProfileCar");
    }
}
