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

    public async ValueTask<List<(Car car, List<Repair> repairs)>> SelectCarsWithFullDetailsAsync()
    {
        using var connection = CreateConnection();
        using var multi = await connection.QueryMultipleAsync(@"SELECT * FROM Car;
        SELECT * FROM Repair;");
        var cars = multi.Read<Car>().ToList();
        var repairs = multi.Read<Repair>().ToList();
        var carRepairList = new List<(Car car, List<Repair> repairs)>();
        foreach (var car in cars)
        {
            var carRepairs = repairs.Where(repair => repair.id == car.id).ToList();
            carRepairList.Add((car, carRepairs));
        }
        return carRepairList;
    }

    public async ValueTask<Car> SelectCarByIdAsync(string carId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Car>("SELECT * FROM Car WHERE Id = @carId;", new { carId });
    }

    public async ValueTask<(Car car, List<Repair> repairs)> SelectCarWithRepairsAsync(string carId)
    {
        using var connection = CreateConnection();
        using var multi = await connection.QueryMultipleAsync(@"
        SELECT * FROM Cars WHERE Id = @CarId;
        SELECT * FROM Repairs WHERE CarId = @CarId;", new { CarId = carId });
        var car = multi.Read<Car>().FirstOrDefault();
        var repairs = multi.Read<Repair>().ToList();
        return (car, repairs);
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