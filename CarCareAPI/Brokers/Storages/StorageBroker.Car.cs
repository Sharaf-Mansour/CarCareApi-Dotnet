using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    
    public async ValueTask InsertCarAsync(Car car)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO Cars (Id, Make, Model, Year, VIN) VALUES (@Id, @Make, @Model, @Year, @VIN);", car);
    }
    public async ValueTask<List<Car>> SelectAllCarsAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<Car>("SELECT * FROM Cars;")).ToList();
    }
    public async ValueTask<Car> SelectCarByIdAsync(string carId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Car>("SELECT * FROM Cars WHERE Id = @Id;", new { Id = carId });
    }
    public async ValueTask UpdateCarAsync(Car car)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE Cars SET Make = @Make, Model = @Model, Year = @Year, VIN = @VIN WHERE Id = @Id;", car);
    }
    public async ValueTask DeleteCarAsync(string carId)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Cars WHERE Id = @Id;", new { Id = carId });
    }
}