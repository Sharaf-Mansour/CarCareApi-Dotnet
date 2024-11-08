using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IRepairTypeService
{
    ValueTask AddRepairTypeAsync(RepairType repairType);
    ValueTask<List<RepairType>> RetrieveAllRepairTypesAsync();
    ValueTask<RepairType> RetrieveRepairTypeByidAsync(string repairtypeid);
    ValueTask ModifyRepairTypeAsync(RepairType repairType);
    ValueTask RemoveRepairTypeByidAsync(string repairtypeid);
}