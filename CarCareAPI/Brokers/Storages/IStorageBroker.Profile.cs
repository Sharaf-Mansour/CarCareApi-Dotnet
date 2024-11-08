using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertProfileAsync(Profile profile);
    ValueTask<List<Profile>> SelectAllProfilesAsync();
    ValueTask<Profile> SelectProfileByIdAsync(string profileId);
    ValueTask UpdateProfileAsync(Profile profile);
    ValueTask DeleteProfileAsync(string profileId);
}
