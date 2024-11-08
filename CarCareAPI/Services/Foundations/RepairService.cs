using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class RepairService (IStorageBroker storageBroker) : IRepairService
{
    public async ValueTask AddRepairAsync(Repair repair)
            => await storageBroker.InsertRepairAsync(repair);
    public async ValueTask<List<Repair>> RetrieveAllRepairsAsync()
        => await storageBroker.SelectAllRepairsAsync();
    public async ValueTask<Repair> RetrieveRepairByidAsync(string repairid)
        => await storageBroker.SelectRepairByidAsync(repairid);
    public async ValueTask ModifyRepairAsync(Repair repair)
        => await storageBroker.UpdateRepairAsync(repair);
    public async ValueTask RemoveRepairByidAsync(string repairid)
        => await storageBroker.DeleteRepairAsync(repairid);
}