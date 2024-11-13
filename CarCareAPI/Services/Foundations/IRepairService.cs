using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IRepairService
{
    ValueTask AddRepairAsync(Repair repair);
    ValueTask<List<Repair>> RetrieveAllRepairsAsync();
    ValueTask<Repair> RetrieveRepairByidAsync(string repairid);
    ValueTask ModifyRepairAsync(Repair repair);
    ValueTask RemoveRepairByidAsync(string repairid);
}