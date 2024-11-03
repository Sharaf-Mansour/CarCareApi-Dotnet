using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertProfileCarAsync(ProfileCar profileCar);
    IQueryable<ProfileCar> SelectAllProfileCarsAsync();
    ValueTask<ProfileCar> SelectProfileCarByIdAsync(string profileCarId);
    ValueTask UpdateProfileCarAsync(ProfileCar profileCar);
    ValueTask DeleteProfileCarAsync(string profileCarId);

}
