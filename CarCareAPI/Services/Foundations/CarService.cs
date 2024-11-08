using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class CarService (IStorageBroker storageBroker) : ICarService
{
    public async ValueTask AddCarAsync(Car car)
            => await storageBroker.InsertCarAsync(car);
    public async ValueTask<List<Car>> RetrieveAllCarsAsync()
        => await storageBroker.SelectAllCarsAsync();
    public async ValueTask<Car> RetrieveCarByIdAsync(string carId)
        => await storageBroker.SelectCarByIdAsync(carId);
    public async ValueTask ModifyCarAsync(Car car)
        => await storageBroker.UpdateCarAsync(car);
    public async ValueTask RemoveCarByIdAsync(string carId)
        => await storageBroker.DeleteCarAsync(carId);
}


