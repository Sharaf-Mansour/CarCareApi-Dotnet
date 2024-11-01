﻿namespace CarCareAPI.Brokers.Storages;
public partial class StorageBroker(IConfiguration configuration) : IStorageBroker
{
    string? ConnectionString => configuration.GetConnectionString("DefaultConnection");
    SqliteConnection CreateConnection() => new (ConnectionString);
}