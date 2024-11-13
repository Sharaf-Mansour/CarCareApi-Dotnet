using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertCarAsync(Car car)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO Car (Id, Make, Model, Year, ClassId, LicenseExpirationDate, ExaminationDate, NotifyEvery, Km, ProfileId) VALUES (@Id, @Make, @Model, @Year, @ClassId, @LicenseExpirationDate, @ExaminationDate, @NotifyEvery, @Km, @ProfileId);", car);

    }
    public async ValueTask<List<Car>> SelectAllCarsAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<Car>("SELECT * FROM Car;")).AsList();
    }
    public async ValueTask<Car> SelectCarByIdAsync(string carId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Car>("SELECT * FROM Car WHERE Id = @carId;", new { carId });
    }
    public async ValueTask UpdateCarAsync(Car car)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE Car SET Make = @Make, Model = @Model, Year = @Year, ClassId = @ClassId, LicenseExpirationDate = @LicenseExpirationDate, ExaminationDate = @ExaminationDate, NotifyEvery = @NotifyEvery, Km = @Km, ProfileId = @ProfileId WHERE Id = @Id;", car);

    }
    public async ValueTask DeleteCarAsync(string carId)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Car WHERE Id = @carId;", new { carId });

    }
}