using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;
public static class RepairController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/repairs", async (IStorageBroker storageBroker) =>
        {
            var repairs = await storageBroker.SelectAllRepairsAsync();
            return Results.Ok(repairs);
        })
        .WithName("GetRepairs");

        app.MapGet("/repairs/{repairid}", async (IStorageBroker storageBroker, string repairid) =>
        {
            var repair = await storageBroker.SelectRepairByIdAsync(repairid);
            return repair is not null ? Results.Ok(repair) : Results.NotFound();
        })
        .WithName("GetRepairByid");

        app.MapPost("/repairs", async (IStorageBroker storageBroker, Repair repair) =>
        {
            await storageBroker.InsertRepairAsync(repair);
            return Results.Created($"/repairs/{repair.id}", repair);
        })
        .WithName("PostRepair");

        app.MapPut("/repairs/{repairid}", async (IStorageBroker storageBroker, string repairid, Repair repair) =>
        {
            repair.id = repairid;
            await storageBroker.UpdateRepairAsync(repair);
            return Results.NoContent();
        })
        .WithName("PutRepair");

        app.MapDelete("/repairs/{repairid}", async (IStorageBroker storageBroker, string repairid) =>
        {
            await storageBroker.DeleteRepairAsync(repairid);
            return Results.NoContent();
        })
        .WithName("DeleteRepair");
    }
}