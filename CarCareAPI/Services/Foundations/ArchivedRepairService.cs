using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ArchivedRepairService (IStorageBroker storageBroker) : IArchivedRepairService
{
    public async ValueTask AddArchivedRepairAsync(ArchivedRepair archivedRepair)
            => await storageBroker.InsertArchivedRepairAsync(archivedRepair);
    public async ValueTask<List<ArchivedRepair>> RetrieveAllArchivedRepairsAsync()
        => await storageBroker.SelectAllArchivedRepairsAsync();
    public async ValueTask<ArchivedRepair> RetrieveArchivedRepairByidAsync(string archivedrepairid)
        => await storageBroker.SelectArchivedRepairByIdAsync(archivedrepairid);
    public async ValueTask ModifyArchivedRepairAsync(ArchivedRepair archivedRepair)
        => await storageBroker.UpdateArchivedRepairAsync(archivedRepair);
    public async ValueTask RemoveArchivedRepairByidAsync(string archivedrepairid)
        => await storageBroker.DeleteArchivedRepairAsync(archivedrepairid);
}