using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class RepairTypeService(IStorageBroker storageBroker) : IRepairTypeService
{
    public async ValueTask AddRepairTypeAsync(RepairType repairType)
        => await storageBroker.InsertRepairTypeAsync(repairType);
    public async ValueTask<List<RepairType>> RetrieveAllRepairTypesAsync()
        => await storageBroker.SelectAllRepairTypesAsync();
    public async ValueTask<RepairType> RetrieveRepairTypeByidAsync(string repairtypeid)
        => await storageBroker.SelectRepairTypeByidAsync(repairtypeid);
    public async ValueTask ModifyRepairTypeAsync(RepairType repairType)
        => await storageBroker.UpdateRepairTypeAsync(repairType);
    public async ValueTask RemoveRepairTypeByidAsync(string repairtypeid)
        => await storageBroker.DeleteRepairTypeAsync(repairtypeid);
}   