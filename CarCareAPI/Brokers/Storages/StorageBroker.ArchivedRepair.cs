using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertArchivedRepairAsync(ArchivedRepair archivedRepair)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO ArchivedRepairs (Id, CarId, Description, Cost, Date) VALUES (@Id, @CarId, @Description, @Cost, @Date);", archivedRepair);
    }
    public async ValueTask<List<ArchivedRepair>> SelectAllArchivedRepairsAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<ArchivedRepair>("SELECT * FROM ArchivedRepairs;")).ToList();
    }
    public async ValueTask<ArchivedRepair> SelectArchivedRepairByIdAsync(string archivedRepairId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<ArchivedRepair>("SELECT * FROM ArchivedRepairs WHERE Id = @ArchivedRepairId;", new { ArchivedRepairId = archivedRepairId });
    }
    public async ValueTask UpdateArchivedRepairAsync(ArchivedRepair archivedRepair)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE ArchivedRepairs SET CarId = @CarId, Description = @Description, Cost = @Cost, Date = @Date WHERE Id = @Id;", archivedRepair);
    }
    public async ValueTask DeleteArchivedRepairAsync(string archivedRepairId)
    {
        await using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM ArchivedRepairs WHERE Id = @ArchivedRepairId;", new { ArchivedRepairId = archivedRepairId });
    }
}
