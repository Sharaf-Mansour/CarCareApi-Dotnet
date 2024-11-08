using CarCareAPI.Brokers.Storages;
using CarCareAPI.models;
namespace CarCareAPI.Controllers;
public static class GasController
{
   public static void RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/gases", async (IStorageBroker storageBroker) =>
        {
            var gases = await storageBroker.SelectAllGasesAsync();
            return Results.Ok(gases);
        })
            .Withname("GetGases");

        app.MapGet("/gases/{gasid}", async (IStorageBroker storageBroker, string gasid) =>
        {
            var gas = await storageBroker.SelectGasByidAsync(gasid);
            return gas is not null ? Results.Ok(gas) : Results.NotFound();
        })
            .Withname("GetGasByid");

        app.MapPost("/gases", async (IStorageBroker storageBroker, Gas gas) =>
        {
            await storageBroker.InsertGasAsync(gas);
            return Results.Created($"/gases/{gas.id}", gas);
        })
            .Withname("PostGas");

        app.MapPut("/gases/{gasid}", async (IStorageBroker storageBroker, string gasid, Gas gas) =>
        {
            gas.id = gasid;
            await storageBroker.UpdateGasAsync(gas);
            return Results.NoContent();
        })
            .Withname("PutGas");

        app.MapDelete("/gases/{gasid}", async (IStorageBroker storageBroker, string gasid) =>
        {
            await storageBroker.DeleteGasAsync(gasid);
            return Results.NoContent();
        })
            .Withname("DeleteGas");
    }
}
