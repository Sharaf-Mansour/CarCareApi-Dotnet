using CarCareAPI.models;
using CarCareAPI.Brokers.Storages;
namespace CarCareAPI.Services.Foundations;
public class CarClassService(IStorageBroker storageBroker) : ICarClassService
{
    public async ValueTask AddCarClassAsync(CarClass carClass)
        => await storageBroker.InsertCarClassAsync(carClass);
    public async ValueTask<List<CarClass>> RetrieveAllCarClassesAsync()
        => await storageBroker.SelectAllCarClassesAsync();
    public async ValueTask<CarClass> RetrieveCarClassByidAsync(string carclassid)
        => await storageBroker.SelectCarClassByIdAsync(carclassid);
    public async ValueTask ModifyCarClassAsync(CarClass carClass)
        => await storageBroker.UpdateCarClassAsync(carClass);
    public async ValueTask RemoveCarClassByidAsync(string carclassid)
        => await storageBroker.DeleteCarClassAsync(carclassid);
}