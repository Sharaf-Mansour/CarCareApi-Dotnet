using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker  
{
    public async ValueTask<CarClass> InsertCarClassAsync(CarClass carClass)
    {
        using var connection = CreateConnection();
        await connection.executeAsync("INSERT INTO CarClass (Id, Name) VALUES (@Id, @Name);", carClass);
        return carClass;
    }
    public async ValueTask<List<CarClass>> SelectAllCarClassesAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<CarClass>("SELECT * FROM CarClass;")).ToList();
    }
    public async ValueTask<CarClass> SelectCarClassByIdAsync(string carClassId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<CarClass>("SELECT * FROM CarClass WHERE Id = @Id;", new { Id = carClassId });
    }
    public async ValueTask UpdateCarClassAsync(CarClass carClass)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE CarClass SET Name = @Name WHERE Id = @Id;", carClass);
    }
    public async ValueTask DeleteCarClassAsync(string carClassId)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM CarClass WHERE Id = @Id;", new { Id = carClassId });
    }
}
