using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ProfileService(IStorageBroker storageBroker) : IProfileService
{
    public async ValueTask AddProfileAsync(Profile profile)
        => await storageBroker.InsertProfileAsync(profile);
    public async ValueTask<List<Profile>> RetrieveAllProfilesAsync()
        => await storageBroker.SelectAllProfilesAsync();
    public async ValueTask<Profile> RetrieveProfileByIdAsync(string profileId)
        => await storageBroker.SelectProfileByIdAsync(profileId);
    public async ValueTask ModifyProfileAsync(Profile profile)
        => await storageBroker.UpdateProfileAsync(profile);
    public async ValueTask RemoveProfileByIdAsync(string profileId)
        => await storageBroker.DeleteProfileAsync(profileId);
}