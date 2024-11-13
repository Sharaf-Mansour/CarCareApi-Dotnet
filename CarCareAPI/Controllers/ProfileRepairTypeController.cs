using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;

public static class ProfileRepairTypeController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/profile-repair-types", async (IStorageBroker storageBroker) =>
        {
            var profileRepairTypes = await storageBroker.SelectAllProfileRepairTypesAsync();
            return Results.Ok(profileRepairTypes);
        })
        .WithName("GetProfileRepairTypes");

        app.MapGet("/profile-repair-types/{profilerepairtypeid}", async (IStorageBroker storageBroker, string profilerepairtypeid) =>
        {
            var profileRepairType = await storageBroker.SelectProfileRepairTypeByIdAsync(profilerepairtypeid);
            return profileRepairType is not null ? Results.Ok(profileRepairType) : Results.NotFound();
        })
        .WithName("GetProfileRepairTypeByid");

        app.MapPost("/profile-repair-types", async (IStorageBroker storageBroker, ProfileRepairType profileRepairType) =>
        {
            await storageBroker.InsertProfileRepairTypeAsync(profileRepairType);
            return Results.Created($"/profile-repair-types/{profileRepairType.profileid}", profileRepairType);
        })
            .WithName("PostProfileRepairType");
        //profileid

        app.MapPut("/profile-repair-types/{profilerepairtypeid}", async (IStorageBroker storageBroker, string profilerepairtypeid, ProfileRepairType profileRepairType) =>
        {
            profileRepairType.repairtypeid = profilerepairtypeid;
            await storageBroker.UpdateProfileRepairTypeAsync(profileRepairType);
            return Results.NoContent();
        })
            .WithName("PutProfileRepairType");

        app.MapDelete("/profile-repair-types/{profilerepairtypeid}", async (IStorageBroker storageBroker, string profilerepairtypeid) =>
        {
            await storageBroker.DeleteProfileRepairTypeAsync(profilerepairtypeid);
            return Results.NoContent();
        })
            .WithName("DeleteProfileRepairType");

    }
}