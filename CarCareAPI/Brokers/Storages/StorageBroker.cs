
namespace CarCareAPI.Brokers.Storages;
public class StorageBroker(IConfiguration configuration) : IStorageBroker
{
    string? ConnectionString => configuration.GetConnectionString("DefaultConnection");
    IDbConnection CreateConnection() => new SqliteConnection(ConnectionString);
}