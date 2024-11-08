using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface IProfileCarService
{
    ValueTask AddProfileCarAsync(ProfileCar profileCar);
    ValueTask<List<ProfileCar>> RetrieveAllProfileCarsAsync();
    ValueTask<ProfileCar> RetrieveProfileCarByidAsync(string profilecarid);
    ValueTask ModifyProfileCarAsync(ProfileCar profileCar);
    ValueTask RemoveProfileCarByidAsync(string profilecarid);
}
