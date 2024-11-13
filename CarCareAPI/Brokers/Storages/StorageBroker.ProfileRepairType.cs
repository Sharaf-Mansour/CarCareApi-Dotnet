using CarCareAPI.models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertProfileRepairTypeAsync(ProfileRepairType profileRepairType)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO ProfileRepairType (ProfileId, RepairTypeId) VALUES (@ProfileId, @RepairTypeId);", profileRepairType);
    }
    public async ValueTask<List<ProfileRepairType>> SelectAllProfileRepairTypesAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<ProfileRepairType>("SELECT * FROM ProfileRepairType;")).AsList();
    }
    public async ValueTask<ProfileRepairType> SelectProfileRepairTypeByIdAsync(string profileRepairTypeId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<ProfileRepairType>("SELECT * FROM ProfileRepairType WHERE Id = @ProfileRepairTypeId;", new { ProfileRepairTypeId = profileRepairTypeId });
    }
    public async ValueTask UpdateProfileRepairTypeAsync(ProfileRepairType profileRepairType)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE ProfileRepairType SET ProfileId = @ProfileId, RepairTypeId = @RepairTypeId WHERE Id = @Id;", profileRepairType);
    }
    public async ValueTask DeleteProfileRepairTypeAsync(string profileRepairTypeId)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM ProfileRepairType WHERE Id = @ProfileRepairTypeId;", new { ProfileRepairTypeId = profileRepairTypeId });
    }
}