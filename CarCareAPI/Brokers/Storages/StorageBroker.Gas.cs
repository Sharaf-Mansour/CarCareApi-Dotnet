using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertGasAsync(Gas gas)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("insert into Gas values(@Id, @Cost, @Km, @Date, @Liters, @Model, @CarId);", gas);
    }
    public async ValueTask<List<Gas>> SelectAllGasesAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<Gas>("select * from Gas;")).ToList();
    }
    public async ValueTask<Gas> SelectGasByIdAsync(string gasId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Gas>("select * from Gas where Id = @GasId;", new { GasId = gasId });
    }
    public async ValueTask UpdateGasAsync(Gas gas)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("update Gas set Cost = @Cost, Km = @Km, Date = @Date, Liters = @Liters, Model = @Model, CarId = @CarId where Id = @Id;", gas);
    }
    public async ValueTask DeleteGasAsync(string gasId)
    {
        await using var connection = CreateConnection();
        await connection.ExecuteAsync("delete from Gas where Id = @GasId;", new { GasId = gasId });
    }
    public async ValueTask<List<Gas>> TrackGasAsync(string carId)
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<Gas>("select * from Gas where CarId = @CarId;", new { CarId = carId })).ToList();
    }
}