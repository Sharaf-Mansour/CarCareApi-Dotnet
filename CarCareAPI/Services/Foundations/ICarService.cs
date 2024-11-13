using CarCareAPI.models;
namespace CarCareAPI.Services.Foundations;
public interface ICarService
{
    ValueTask AddCarAsync(Car car);
    ValueTask<List<Car>> RetrieveAllCarsAsync();
    ValueTask<Car> RetrieveCarByidAsync(string carid);
    ValueTask ModifyCarAsync(Car car);
    ValueTask RemoveCarByidAsync(string carid);
}