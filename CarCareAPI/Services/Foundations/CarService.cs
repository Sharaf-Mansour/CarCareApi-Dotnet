using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class CarService (IStorageBroker storageBroker) : ICarService
{
    public async ValueTask AddCarAsync(Car car)
            => await storageBroker.InsertCarAsync(car);
    public async ValueTask<List<Car>> RetrieveAllCarsAsync()
        => await storageBroker.SelectAllCarsAsync();
    public async ValueTask<Car> RetrieveCarByidAsync(string carid)
        => await storageBroker.SelectCarByidAsync(carid);
    public async ValueTask ModifyCarAsync(Car car)
        => await storageBroker.UpdateCarAsync(car);
    public async ValueTask RemoveCarByidAsync(string carid)
        => await storageBroker.DeleteCarAsync(carid);
}


