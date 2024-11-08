using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface ICarClassService
{
    ValueTask AddCarClassAsync(CarClass carClass);
    ValueTask<List<CarClass>> RetrieveAllCarClassesAsync();
    ValueTask<CarClass> RetrieveCarClassByIdAsync(string carClassId);
    ValueTask ModifyCarClassAsync(CarClass carClass);
    ValueTask RemoveCarClassByIdAsync(string carClassId);
}