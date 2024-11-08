using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface IProfileCarService
{
    ValueTask AddProfileCarAsync(ProfileCar profileCar);
    ValueTask<List<ProfileCar>> RetrieveAllProfileCarsAsync();
    ValueTask<ProfileCar> RetrieveProfileCarByIdAsync(string profileCarId);
    ValueTask ModifyProfileCarAsync(ProfileCar profileCar);
    ValueTask RemoveProfileCarByIdAsync(string profileCarId);
}
