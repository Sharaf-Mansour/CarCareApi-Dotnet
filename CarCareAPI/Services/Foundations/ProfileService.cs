using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ProfileService(IStorageBroker storageBroker) : IProfileService
{
    public async ValueTask AddProfileAsync(Profile profile)
        => await storageBroker.InsertProfileAsync(profile);
    public async ValueTask<List<Profile>> RetrieveAllProfilesAsync()
        => await storageBroker.SelectAllProfilesAsync();
    public async ValueTask<Profile> RetrieveProfileByidAsync(string profileid)
        => await storageBroker.SelectProfileByidAsync(profileid);
    public async ValueTask ModifyProfileAsync(Profile profile)
        => await storageBroker.UpdateProfileAsync(profile);
    public async ValueTask RemoveProfileByidAsync(string profileid)
        => await storageBroker.DeleteProfileAsync(profileid);
}