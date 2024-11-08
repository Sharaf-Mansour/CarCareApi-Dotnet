using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class RepairService (IStorageBroker storageBroker) : IRepairService
{
    public async ValueTask AddRepairAsync(Repair repair)
            => await storageBroker.InsertRepairAsync(repair);
    public async ValueTask<List<Repair>> RetrieveAllRepairsAsync()
        => await storageBroker.SelectAllRepairsAsync();
    public async ValueTask<Repair> RetrieveRepairByIdAsync(string repairId)
        => await storageBroker.SelectRepairByIdAsync(repairId);
    public async ValueTask ModifyRepairAsync(Repair repair)
        => await storageBroker.UpdateRepairAsync(repair);
    public async ValueTask RemoveRepairByIdAsync(string repairId)
        => await storageBroker.DeleteRepairAsync(repairId);
}