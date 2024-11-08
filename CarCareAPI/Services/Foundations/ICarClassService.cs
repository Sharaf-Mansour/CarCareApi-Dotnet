using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface ICarClassService
{
    ValueTask AddCarClassAsync(CarClass carClass);
    ValueTask<List<CarClass>> RetrieveAllCarClassesAsync();
    ValueTask<CarClass> RetrieveCarClassByidAsync(string carclassid);
    ValueTask ModifyCarClassAsync(CarClass carClass);
    ValueTask RemoveCarClassByidAsync(string carclassid);
}