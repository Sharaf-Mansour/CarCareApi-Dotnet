using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertRepairTypeAsync(RepairType repairType);
    ValueTask<List<RepairType>> SelectAllRepairTypesAsync();
    ValueTask<RepairType> SelectRepairTypeByIdAsync(string repairTypeId);
    ValueTask UpdateRepairTypeAsync(RepairType repairType);
    ValueTask DeleteRepairTypeAsync(string repairTypeId);
}