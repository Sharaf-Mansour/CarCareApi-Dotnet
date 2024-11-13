using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;
public static class RepairTypeController
{
    public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/repairTypes", async (IStorageBroker storageBroker) =>
        {
            var repairTypes = await storageBroker.SelectAllRepairTypesAsync();
            return Results.Ok(repairTypes);
        })
        .WithName("GetRepairTypes");

        app.MapGet("/repairTypes/{repairtypeid}", async (IStorageBroker storageBroker, string repairtypeid) =>
        {
            var repairType = await storageBroker.SelectRepairTypeByIdAsync(repairtypeid);
            return repairType is not null ? Results.Ok(repairType) : Results.NotFound();
        })
        .WithName("GetRepairTypeByid");

        app.MapPost("/repairTypes", async (IStorageBroker storageBroker, RepairType repairType) =>
        {
            await storageBroker.InsertRepairTypeAsync(repairType);
            return Results.Created($"/repairTypes/{repairType.id}", repairType);
        })
            .WithName("PostRepairType");

        app.MapPut("/repairTypes/{repairtypeid}", async (IStorageBroker storageBroker, string repairtypeid, RepairType repairType) =>
        {
            repairType.id = repairtypeid;
            await storageBroker.UpdateRepairTypeAsync(repairType);
            return Results.NoContent();
        })
            .WithName("PutRepairType");

        app.MapDelete("/repairTypes/{repairtypeid}", async (IStorageBroker storageBroker, string repairtypeid) =>
        {
            await storageBroker.DeleteRepairTypeAsync(repairtypeid);
            return Results.NoContent();
        })
            .WithName("DeleteRepairType");
    }
}