using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public ValueTask InsertProfileAsync(Profile profile)
    {
        using var connection = CreateConnection();
        connection.ExecuteAsync("INSERT INTO Profile (Id, FirstName, LastName, Email) VALUES (@Id, @FirstName, @LastName, @Email);", profile);
    }
    public IQueryable<Profile> SelectAllProfilesAsync()
    {
        using var connection = CreateConnection();
        return connection.QueryAsync<Profile>("SELECT * FROM Profile;").ToList();
    }
    public ValueTask<Profile> SelectProfileByIdAsync(string profileId)
    {
        using var connection = CreateConnection();
        return connection.QueryFirstOrDefaultAsync<Profile>("SELECT * FROM Profile WHERE Id = @ProfileId;", new { ProfileId = profileId });
    }
    public ValueTask UpdateProfileAsync(Profile profile)
    {
        using var connection = CreateConnection();
        return connection.ExecuteAsync("UPDATE Profile SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @Id;", profile);
    }
    public ValueTask DeleteProfileAsync(string profileId)
    {
        using var connection = CreateConnection();
        return connection.ExecuteAsync("DELETE FROM Profile WHERE Id = @ProfileId;", new { ProfileId = profileId });
    }
}
