using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IProfileService
{
    ValueTask AddProfileAsync(Profile profile);
    ValueTask<List<Profile>> RetrieveAllProfilesAsync();
    ValueTask<Profile> RetrieveProfileByidAsync(string profileid);
    ValueTask ModifyProfileAsync(Profile profile);
    ValueTask RemoveProfileByidAsync(string profileid);
}