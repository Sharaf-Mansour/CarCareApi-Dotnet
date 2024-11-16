using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertRepairTypeAsync(RepairType repairType);
    ValueTask InsertCustomRepairTypeAsync(RepairType repairType);
    ValueTask<List<RepairType>> SelectCustomRepairTypesAsync(string profileId);
    ValueTask UpdateCustomRepairTypeAsync(RepairType repairType);
    ValueTask<List <RepairType>> SelectCustomRepairTypeAndDefaultRepairTypeAsync(string profileId);
    ValueTask<List<RepairType>> SelectAllRepairTypesAsync();
    ValueTask<RepairType> SelectRepairTypeByIdAsync(string repairTypeId);
    ValueTask UpdateRepairTypeAsync(RepairType repairType);
    ValueTask DeleteRepairTypeAsync(string repairTypeId);
}