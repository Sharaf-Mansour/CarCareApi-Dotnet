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
        .Withname("GetRepairTypes");

        app.MapGet("/repairTypes/{repairtypeid}", async (IStorageBroker storageBroker, string repairtypeid) =>
        {
            var repairType = await storageBroker.SelectRepairTypeByidAsync(repairtypeid);
            return repairType is not null ? Results.Ok(repairType) : Results.NotFound();
        })
        .Withname("GetRepairTypeByid");

        app.MapPost("/repairTypes", async (IStorageBroker storageBroker, RepairType repairType) =>
        {
            await storageBroker.InsertRepairTypeAsync(repairType);
            return Results.Created($"/repairTypes/{repairType.id}", repairType);
        })
            .Withname("PostRepairType");

        app.MapPut("/repairTypes/{repairtypeid}", async (IStorageBroker storageBroker, string repairtypeid, RepairType repairType) =>
        {
            repairType.id = repairtypeid;
            await storageBroker.UpdateRepairTypeAsync(repairType);
            return Results.NoContent();
        })
            .Withname("PutRepairType");

        app.MapDelete("/repairTypes/{repairtypeid}", async (IStorageBroker storageBroker, string repairtypeid) =>
        {
            await storageBroker.DeleteRepairTypeAsync(repairtypeid);
            return Results.NoContent();
        })
            .Withname("DeleteRepairType");
    }
}
