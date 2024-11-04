using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ArchivedRepairService (IStorageBroker storageBroker) : IArchivedRepairService
{
    public async ValueTask AddArchivedRepairAsync(ArchivedRepair archivedRepair)
            => await storageBroker.InsertArchivedRepairAsync(archivedRepair);
    public async ValueTask<List<ArchivedRepair>> RetrieveAllArchivedRepairsAsync()
        => await storageBroker.SelectAllArchivedRepairsAsync();
    public async ValueTask<ArchivedRepair> RetrieveArchivedRepairByIdAsync(string archivedRepairId)
        => await storageBroker.SelectArchivedRepairByIdAsync(archivedRepairId);
    public async ValueTask ModifyArchivedRepairAsync(ArchivedRepair archivedRepair)
        => await storageBroker.UpdateArchivedRepairAsync(archivedRepair);
    public async ValueTask RemoveArchivedRepairByIdAsync(string archivedRepairId)
        => await storageBroker.DeleteArchivedRepairAsync(archivedRepairId);
}

