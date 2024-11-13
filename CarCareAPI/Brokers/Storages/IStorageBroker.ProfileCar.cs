using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertProfileCarAsync(ProfileCar profileCar);
    ValueTask<List<ProfileCar>> SelectAllProfileCarsAsync();
    ValueTask<ProfileCar> SelectProfileCarByIdAsync(string profileCarId);
    ValueTask UpdateProfileCarAsync(ProfileCar profileCar);
    ValueTask DeleteProfileCarAsync(string profileCarId);

}