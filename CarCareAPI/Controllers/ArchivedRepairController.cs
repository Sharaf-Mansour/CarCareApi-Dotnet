using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;

public static class ArchivedRepairController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/archived-repairs", async (IStorageBroker storageBroker) =>
        {
            var archivedRepairs = await storageBroker.SelectAllArchivedRepairsAsync();
            return Results.Ok(archivedRepairs);
        })
        .Withname("GetArchivedRepairs");

        app.MapGet("/archived-repairs/{archivedrepairid}", async (IStorageBroker storageBroker, string archivedrepairid) =>
        {
            var archivedRepair = await storageBroker.SelectArchivedRepairByidAsync(archivedrepairid);
            return archivedRepair is not null ? Results.Ok(archivedRepair) : Results.NotFound();
        })
        .Withname("GetArchivedRepairByid");

        app.MapPost("/archived-repairs", async (IStorageBroker storageBroker, ArchivedRepair archivedRepair) =>
        {
            await storageBroker.InsertArchivedRepairAsync(archivedRepair);
            return Results.Created($"/archived-repairs/{archivedRepair.id}", archivedRepair);
        })
        .Withname("PostArchivedRepair");

        app.MapPut("/archived-repairs/{archivedrepairid}", async (IStorageBroker storageBroker, string archivedrepairid, ArchivedRepair archivedRepair) =>
        {
            archivedRepair.id = archivedrepairid;
            await storageBroker.UpdateArchivedRepairAsync(archivedRepair);
            return Results.NoContent();
        })
        .Withname("PutArchivedRepair");

        app.MapDelete("/archived-repairs/{archivedrepairid}", async (IStorageBroker storageBroker, string archivedrepairid) =>
        {
            await storageBroker.DeleteArchivedRepairAsync(archivedrepairid);
            return Results.NoContent();
        })
        .Withname("DeleteArchivedRepair");
    }
}
