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
        .WithName("GetProfiles");

        app.MapGet("/profiles/{profileid}", async (IStorageBroker storageBroker, string profileid) =>
        {
            var profile = await storageBroker.SelectProfileByIdAsync(profileid);
            return profile is not null ? Results.Ok(profile) : Results.NotFound();
        })
        .WithName("GetProfileByid");

        app.MapPost("/profiles", async (IStorageBroker storageBroker, Profile profile) =>
        {
            await storageBroker.InsertProfileAsync(profile);
            return Results.Created($"/profiles/{profile.id}", profile);
        })
        .WithName("PostProfile");

        app.MapPut("/profiles/{profileid}", async (IStorageBroker storageBroker, string profileid, Profile profile) =>
        {
            profile.id = profileid;
            await storageBroker.UpdateProfileAsync(profile);
            return Results.NoContent();
        })
        .WithName("PutProfile");

        app.MapDelete("/profiles/{profileid}", async (IStorageBroker storageBroker, string profileid) =>
        {
            await storageBroker.DeleteProfileAsync(profileid);
            return Results.NoContent();
        })
        .WithName("DeleteProfile");
    }
}