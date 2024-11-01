using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask InsertCar(Car car);
    ValueTask<List<Car>> SelectAllCars();
    ValueTask<Car> SelectCarById(int carId);
    ValueTask UpdateCar(Car car);
    ValueTask DeleteCar(int carId);
}