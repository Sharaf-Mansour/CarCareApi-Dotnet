using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IRepairTypeService
{
    ValueTask AddRepairTypeAsync(RepairType repairType);
    ValueTask<List<RepairType>> RetrieveAllRepairTypesAsync();
    ValueTask<RepairType> RetrieveRepairTypeByIdAsync(string repairTypeId);
    ValueTask ModifyRepairTypeAsync(RepairType repairType);
    ValueTask RemoveRepairTypeByIdAsync(string repairTypeId);
}