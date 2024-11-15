using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertRepairTypeAsync(RepairType repairType)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO RepairType (Id, Name, ReminderKm, ProfileId) VALUES (@Id, @Name, @ReminderKm, @ProfileId);", repairType);
    }
    public async ValueTask InsertCustomRepairTypeAsync(RepairType repairType)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO RepairType (Id,Name, ReminderKm, ProfileId) VALUES (@Id,@Name, @ReminderKm, @ProfileId);", repairType);
    }
    public async ValueTask<List<RepairType>> SelectAllRepairTypesAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<RepairType>("SELECT * FROM RepairType;")).AsList();
    }
    public async ValueTask<RepairType> SelectRepairTypeByIdAsync(string repairTypeId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<RepairType>("SELECT * FROM RepairType WHERE Id = @repairTypeId;", new { repairTypeId });
    }
    public async ValueTask UpdateRepairTypeAsync(RepairType repairType)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE RepairType SET Name = @Name, ReminderKm = @ReminderKm, ProfileId = @ProfileId WHERE Id = @Id;", repairType);
    }
    public async ValueTask DeleteRepairTypeAsync(string repairTypeId)
    {
        await using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM RepairType WHERE Id = @repairTypeId;", new { repairTypeId });
    }
}