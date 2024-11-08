using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class ProfileCarService(IStorageBroker storageBroker) : IProfileCarService
{
    public async ValueTask AddProfileCarAsync(ProfileCar profileCar)
        => await storageBroker.InsertProfileCarAsync(profileCar);
    public async ValueTask<List<ProfileCar>> RetrieveAllProfileCarsAsync()
        => await storageBroker.SelectAllProfileCarsAsync();
    public async ValueTask<ProfileCar> RetrieveProfileCarByidAsync(string profilecarid)
        => await storageBroker.SelectProfileCarByidAsync(profilecarid);
    public async ValueTask ModifyProfileCarAsync(ProfileCar profileCar)
        => await storageBroker.UpdateProfileCarAsync(profileCar);
    public async ValueTask RemoveProfileCarByidAsync(string profilecarid)
        => await storageBroker.DeleteProfileCarAsync(profilecarid);
}