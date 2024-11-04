using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertArchivedRepairAsync(ArchivedRepair archivedRepair);
    ValueTask<List<ArchivedRepair>> SelectAllArchivedRepairsAsync();
    ValueTask<ArchivedRepair> SelectArchivedRepairByIdAsync(string archivedRepairId);
    ValueTask UpdateArchivedRepairAsync(ArchivedRepair archivedRepair);
    ValueTask DeleteArchivedRepairAsync(string archivedRepairId);
}
