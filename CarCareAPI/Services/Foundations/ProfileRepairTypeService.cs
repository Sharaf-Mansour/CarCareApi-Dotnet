using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ProfileRepairTypeService(IStorageBroker storageBroker) : IProfileRepairTypeService  
{
    public async ValueTask AddProfileRepairTypeAsync(ProfileRepairType profileRepairType)
        => await storageBroker.InsertProfileRepairTypeAsync(profileRepairType);
    public async ValueTask<List<ProfileRepairType>> RetrieveAllProfileRepairTypesAsync()
        => await storageBroker.SelectAllProfileRepairTypesAsync();
    public async ValueTask<ProfileRepairType> RetrieveProfileRepairTypeByIdAsync(string profileRepairTypeId)
        => await storageBroker.SelectProfileRepairTypeByIdAsync(profileRepairTypeId);
    public async ValueTask ModifyProfileRepairTypeAsync(ProfileRepairType profileRepairType)
        => await storageBroker.UpdateProfileRepairTypeAsync(profileRepairType);
    public async ValueTask RemoveProfileRepairTypeByIdAsync(string profileRepairTypeId)
        => await storageBroker.DeleteProfileRepairTypeAsync(profileRepairTypeId);
}