using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertCarAsync(Car car);
    ValueTask<List<Car>> SelectAllCarsAsync();
    ValueTask<List<(Car car, List<Repair> repairs)>> SelectCarsWithFullDetailsAsync();
    ValueTask<Car> SelectCarByIdAsync(string carId);
    ValueTask UpdateCarAsync(Car car);
    ValueTask DeleteCarAsync(string carId);
    ValueTask<(Car car, List<Repair> repairs)> SelectCarWithRepairsAsync(string carId);
}