using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class RepairTypeService(IStorageBroker storageBroker) : IRepairTypeService
{
    public async ValueTask AddRepairTypeAsync(RepairType repairType)
        => await storageBroker.InsertRepairTypeAsync(repairType);
    public async ValueTask<List<RepairType>> RetrieveAllRepairTypesAsync()
        => await storageBroker.SelectAllRepairTypesAsync();
    public async ValueTask<RepairType> RetrieveRepairTypeByIdAsync(string repairTypeId)
        => await storageBroker.SelectRepairTypeByIdAsync(repairTypeId);
    public async ValueTask ModifyRepairTypeAsync(RepairType repairType)
        => await storageBroker.UpdateRepairTypeAsync(repairType);
    public async ValueTask RemoveRepairTypeByIdAsync(string repairTypeId)
        => await storageBroker.DeleteRepairTypeAsync(repairTypeId);
}   