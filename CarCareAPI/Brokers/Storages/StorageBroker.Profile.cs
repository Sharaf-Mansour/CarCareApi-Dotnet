using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertProfileAsync(Profile profile)
    {
        using var connection = CreateConnection();
       await connection.ExecuteAsync("INSERT INTO Profile (Id, FirstName, LastName, Email) VALUES (@Id, @FirstName, @LastName, @Email);", profile);
    }
    public async ValueTask<List<Profile>> SelectAllProfilesAsync()
    {
        using var connection = CreateConnection();
        return(await connection.QueryAsync<Profile>("SELECT * FROM Profile;")).AsList();
    }
    public async ValueTask<Profile> SelectProfileByIdAsync(string profileId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Profile>("SELECT * FROM Profile WHERE Id = @ProfileId;", new { ProfileId = profileId });
    }
    public async ValueTask UpdateProfileAsync(Profile profile)
    {
        using var connection = CreateConnection();
       await  connection.ExecuteAsync("UPDATE Profile SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @Id;", profile);
    }
    public async ValueTask DeleteProfileAsync(string profileId)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Profile WHERE Id = @ProfileId;", new { ProfileId = profileId });
    }
}
