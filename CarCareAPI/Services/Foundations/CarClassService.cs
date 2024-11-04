using CarCareAPI.Models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class CarClassService(IStorageBroker storageBroker) : ICarClassService
{
    public async ValueTask AddCarClassAsync(CarClass carClass)
        => await storageBroker.InsertCarClassAsync(carClass);
    public async ValueTask<List<CarClass>> RetrieveAllCarClassesAsync()
        => await storageBroker.SelectAllCarClassesAsync();
    public async ValueTask<CarClass> RetrieveCarClassByIdAsync(string carClassId)
        => await storageBroker.SelectCarClassByIdAsync(carClassId);
    public async ValueTask ModifyCarClassAsync(CarClass carClass)
        => await storageBroker.UpdateCarClassAsync(carClass);
    public async ValueTask RemoveCarClassByIdAsync(string carClassId)
        => await storageBroker.DeleteCarClassAsync(carClassId);
}