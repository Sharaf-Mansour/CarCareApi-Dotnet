using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertRepairAsync(Repair repair);
    IQueryable<Repair> SelectAllRepairsAsync();
    ValueTask<Repair> SelectRepairByIdAsync(string repairId);
    ValueTask UpdateRepairAsync(Repair repair);
    ValueTask DeleteRepairAsync(string repairId);
}
