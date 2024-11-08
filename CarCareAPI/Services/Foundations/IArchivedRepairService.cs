using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IArchivedRepairService         
{
    ValueTask AddArchivedRepairAsync(ArchivedRepair archivedRepair);
    ValueTask<List<ArchivedRepair>> RetrieveAllArchivedRepairsAsync();
    ValueTask<ArchivedRepair> RetrieveArchivedRepairByidAsync(string archivedrepairid);
    ValueTask ModifyArchivedRepairAsync(ArchivedRepair archivedRepair);
    ValueTask RemoveArchivedRepairByidAsync(string archivedrepairid);
}