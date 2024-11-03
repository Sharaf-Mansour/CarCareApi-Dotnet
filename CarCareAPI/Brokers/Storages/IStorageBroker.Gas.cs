using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertGasAsync(Gas gas);
    IQueryable<Gas> SelectAllGasesAsync();
    ValueTask<Gas> SelectGasByIdAsync(string gasId);
    ValueTask UpdateGasAsync(Gas gas);
    ValueTask DeleteGasAsync(string gasId);
}
