using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IArchivedRepairService         
{
    ValueTask AddArchivedRepairAsync(ArchivedRepair archivedRepair);
    ValueTask<List<ArchivedRepair>> RetrieveAllArchivedRepairsAsync();
    ValueTask<ArchivedRepair> RetrieveArchivedRepairByIdAsync(string archivedRepairId);
    ValueTask ModifyArchivedRepairAsync(ArchivedRepair archivedRepair);
    ValueTask RemoveArchivedRepairByIdAsync(string archivedRepairId);
}