using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertCarAsync(Car car);
    ValueTask<List<Car>> SelectAllCarsAsync();
    ValueTask<Car> SelectCarByIdAsync(string carId);
    ValueTask UpdateCarAsync(Car car);
    ValueTask DeleteCarAsync(string carId);
}