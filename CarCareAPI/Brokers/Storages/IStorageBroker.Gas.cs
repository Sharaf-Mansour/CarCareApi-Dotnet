using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertGasAsync(Gas gas);
    ValueTask<List<Gas>> SelectAllGasesAsync();
    ValueTask<Gas> SelectGasByIdAsync(string gasId);
    ValueTask UpdateGasAsync(Gas gas);
    ValueTask DeleteGasAsync(string gasId);
}