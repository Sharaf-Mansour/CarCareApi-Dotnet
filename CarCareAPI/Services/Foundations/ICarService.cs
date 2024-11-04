using CarCareAPI.Models;
namespace CarCareAPI.Services.Foundations;
public interface ICarService
{
    ValueTask AddCarAsync(Car car);
    ValueTask<List<Car>> RetrieveAllCarsAsync();
    ValueTask<Car> RetrieveCarByIdAsync(string carId);
    ValueTask ModifyCarAsync(Car car);
    ValueTask RemoveCarByIdAsync(string carId);
}
