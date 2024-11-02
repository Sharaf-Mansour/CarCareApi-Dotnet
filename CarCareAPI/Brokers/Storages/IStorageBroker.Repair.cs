using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertRepairAsync(Repair repair);
    IQueryable<Repair> SelectAllRepairsAsync();
    ValueTask<Repair> SelectRepairByIdAsync(int repairId);
    ValueTask UpdateRepairAsync(Repair repair);
    ValueTask DeleteRepairAsync(int repairId);
}
