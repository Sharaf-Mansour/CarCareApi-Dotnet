using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;

public static class ProfileController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/profiles", async (IStorageBroker storageBroker) =>
        {
            var profiles = await storageBroker.SelectAllProfilesAsync();
            return Results.Ok(profiles);
        })
        .Withname("GetProfiles");

        app.MapGet("/profiles/{profileid}", async (IStorageBroker storageBroker, string profileid) =>
        {
            var profile = await storageBroker.SelectProfileByidAsync(profileid);
            return profile is not null ? Results.Ok(profile) : Results.NotFound();
        })
        .Withname("GetProfileByid");

        app.MapPost("/profiles", async (IStorageBroker storageBroker, Profile profile) =>
        {
            await storageBroker.InsertProfileAsync(profile);
            return Results.Created($"/profiles/{profile.id}", profile);
        })
        .Withname("PostProfile");

        app.MapPut("/profiles/{profileid}", async (IStorageBroker storageBroker, string profileid, Profile profile) =>
        {
            profile.id = profileid;
            await storageBroker.UpdateProfileAsync(profile);
            return Results.NoContent();
        })
        .Withname("PutProfile");

        app.MapDelete("/profiles/{profileid}", async (IStorageBroker storageBroker, string profileid) =>
        {
            await storageBroker.DeleteProfileAsync(profileid);
            return Results.NoContent();
        })
        .Withname("DeleteProfile");
    }
}
