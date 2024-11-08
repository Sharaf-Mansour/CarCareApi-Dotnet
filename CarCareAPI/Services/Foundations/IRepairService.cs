using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IRepairService
{
    ValueTask AddRepairAsync(Repair repair);
    ValueTask<List<Repair>> RetrieveAllRepairsAsync();
    ValueTask<Repair> RetrieveRepairByIdAsync(string repairId);
    ValueTask ModifyRepairAsync(Repair repair);
    ValueTask RemoveRepairByIdAsync(string repairId);
}
