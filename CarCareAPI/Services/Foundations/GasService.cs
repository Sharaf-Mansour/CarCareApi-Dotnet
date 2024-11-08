using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class GasService(IStorageBroker storageBroker) : IGasService
{
    public async ValueTask AddGasAsync(Gas gas)
        => await storageBroker.InsertGasAsync(gas);
    public async ValueTask<List<Gas>> RetrieveAllGasesAsync()
        => await storageBroker.SelectAllGasesAsync();
    public async ValueTask<Gas> RetrieveGasByidAsync(string gasid)
        => await storageBroker.SelectGasByidAsync(gasid);
    public async ValueTask ModifyGasAsync(Gas gas)
        => await storageBroker.UpdateGasAsync(gas);
    public async ValueTask RemoveGasByidAsync(string gasid)
        => await storageBroker.DeleteGasAsync(gasid);
}