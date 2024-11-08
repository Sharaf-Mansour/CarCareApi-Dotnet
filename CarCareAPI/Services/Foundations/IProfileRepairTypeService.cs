using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IProfileRepairTypeService
{
    ValueTask AddProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask<List<ProfileRepairType>> RetrieveAllProfileRepairTypesAsync();
    ValueTask<ProfileRepairType> RetrieveProfileRepairTypeByidAsync(string profilerepairtypeid);
    ValueTask ModifyProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask RemoveProfileRepairTypeByidAsync(string profilerepairtypeid);
}