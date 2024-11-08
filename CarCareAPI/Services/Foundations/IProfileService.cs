using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IProfileService
{
    ValueTask AddProfileAsync(Profile profile);
    ValueTask<List<Profile>> RetrieveAllProfilesAsync();
    ValueTask<Profile> RetrieveProfileByIdAsync(string profileId);
    ValueTask ModifyProfileAsync(Profile profile);
    ValueTask RemoveProfileByIdAsync(string profileId);
}