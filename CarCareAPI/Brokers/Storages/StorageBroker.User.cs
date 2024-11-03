using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker : IStorageBroker
{
    public async ValueTask InsertUserAsync(User user)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("INSERT INTO User (Id, Email, Password, Username) VALUES (@Id, @Email, @Password, @Username);", user);
    }
    public async ValueTask<List<User>> SelectAllUsersAsync()
    {
        using var connection = CreateConnection();
        return (await connection.QueryAsync<User>("SELECT * FROM User;")).ToList();
    }
    public async ValueTask<User> SelectUserByIdAsync(string Id)
    {
        using var connection = CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<User>("SELECT * FROM User WHERE Id = @Id;",new { Id = Id });
    }
    public async ValueTask UpdateUserAsync(User user)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("UPDATE User SET Email = @Email, Password = @Password, Username = @Username WHERE Id = @Id;", user);
    }
    public async ValueTask DeleteUserAsync(string Id)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Users WHERE Id = @Id;", new { Id = Id });
    }

}
