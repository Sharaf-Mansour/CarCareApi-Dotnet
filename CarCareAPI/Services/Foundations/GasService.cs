using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class GasService(IStorageBroker storageBroker) : IGasService
{
    public async ValueTask AddGasAsync(Gas gas)
        => await storageBroker.InsertGasAsync(gas);
    public async ValueTask<List<Gas>> RetrieveAllGasesAsync()
        => await storageBroker.SelectAllGasesAsync();
    public async ValueTask<Gas> RetrieveGasByIdAsync(string gasId)
        => await storageBroker.SelectGasByIdAsync(gasId);
    public async ValueTask ModifyGasAsync(Gas gas)
        => await storageBroker.UpdateGasAsync(gas);
    public async ValueTask RemoveGasByIdAsync(string gasId)
        => await storageBroker.DeleteGasAsync(gasId);
}