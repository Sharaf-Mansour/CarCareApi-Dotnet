using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IProfileRepairTypeService
{
    ValueTask AddProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask<List<ProfileRepairType>> RetrieveAllProfileRepairTypesAsync();
    ValueTask<ProfileRepairType> RetrieveProfileRepairTypeByIdAsync(string profileRepairTypeId);
    ValueTask ModifyProfileRepairTypeAsync(ProfileRepairType profileRepairType);
    ValueTask RemoveProfileRepairTypeByIdAsync(string profileRepairTypeId);
}