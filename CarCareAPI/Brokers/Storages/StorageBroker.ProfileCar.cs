using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertProfileCarAsync(ProfileCar profileCar)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO ProfileCar (ProfileId, CarId) VALUES (@ProfileId, @CarId);", profileCar);
    }
    public async ValueTask<List<ProfileCar>> SelectAllProfileCarsAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<ProfileCar>("SELECT * FROM ProfileCar;")).ToList();
    }
    public async ValueTask<ProfileCar> SelectProfileCarByIdAsync(string profileCarId)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<ProfileCar>("SELECT * FROM ProfileCar WHERE Id = @ProfileCarId;", new { ProfileCarId = profileCarId });
    }
    public async ValueTask UpdateProfileCarAsync(ProfileCar profileCar)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE ProfileCar SET ProfileId = @ProfileId, CarId = @CarId WHERE Id = @Id;", profileCar);
    }
    public async ValueTask DeleteProfileCarAsync(string profileCarId)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM ProfileCar WHERE Id = @ProfileCarId;", new { ProfileCarId = profileCarId });
    }
}
