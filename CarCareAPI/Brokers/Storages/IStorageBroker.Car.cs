using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial interface IStorageBroker
{
    Task InsertCar(Car car);
    Task<List<Car>> SelectAllCars();
    Task<Car> SelectCarById(int carId);
    Task UpdateCar(Car car);
    Task DeleteCar(int carId);
}