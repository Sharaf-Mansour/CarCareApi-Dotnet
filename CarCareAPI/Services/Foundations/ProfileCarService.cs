using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ProfileCarService(IStorageBroker storageBroker) : IProfileCarService
{
    public async ValueTask AddProfileCarAsync(ProfileCar profileCar)
        => await storageBroker.InsertProfileCarAsync(profileCar);
    public async ValueTask<List<ProfileCar>> RetrieveAllProfileCarsAsync()
        => await storageBroker.SelectAllProfileCarsAsync();
    public async ValueTask<ProfileCar> RetrieveProfileCarByIdAsync(string profileCarId)
        => await storageBroker.SelectProfileCarByIdAsync(profileCarId);
    public async ValueTask ModifyProfileCarAsync(ProfileCar profileCar)
        => await storageBroker.UpdateProfileCarAsync(profileCar);
    public async ValueTask RemoveProfileCarByIdAsync(string profileCarId)
        => await storageBroker.DeleteProfileCarAsync(profileCarId);
}