using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ProfileRepairTypeService(IStorageBroker storageBroker) : IProfileRepairTypeService  
{
    public async ValueTask AddProfileRepairTypeAsync(ProfileRepairType profileRepairType)
        => await storageBroker.InsertProfileRepairTypeAsync(profileRepairType);
    public async ValueTask<List<ProfileRepairType>> RetrieveAllProfileRepairTypesAsync()
        => await storageBroker.SelectAllProfileRepairTypesAsync();
    public async ValueTask<ProfileRepairType> RetrieveProfileRepairTypeByidAsync(string profilerepairtypeid)
        => await storageBroker.SelectProfileRepairTypeByIdAsync(profilerepairtypeid);
    public async ValueTask ModifyProfileRepairTypeAsync(ProfileRepairType profileRepairType)
        => await storageBroker.UpdateProfileRepairTypeAsync(profileRepairType);
    public async ValueTask RemoveProfileRepairTypeByidAsync(string profilerepairtypeid)
        => await storageBroker.DeleteProfileRepairTypeAsync(profilerepairtypeid);
}