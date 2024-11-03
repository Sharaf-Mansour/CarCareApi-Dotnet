using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertRepairAsync(Repair repair)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO Repair (Id, CarId, Description, Cost, Date) VALUES (@Id, @CarId, @Description, @Cost, @Date);", repair);
    }
    public async ValueTask<List<Repair>> SelectAllRepairsAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<Repair>("SELECT * FROM Repair;")).ToList();
    }
    public async ValueTask<Repair> SelectRepairByIdAsync(string repairId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Repair>("SELECT * FROM Repair WHERE Id = @RepairId;", new { RepairId = repairId });
    }
    public async ValueTask UpdateRepairAsync(Repair repair)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE Repair SET CarId = @CarId, Description = @Description, Cost = @Cost, Date = @Date WHERE Id = @Id;", repair);
    }
    public async ValueTask DeleteRepairAsync(string repairId)
    {
        await using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Repairs WHERE Id = @RepairId;", new { RepairId = repairId });
    }
}

