global using Dapper;
global using Microsoft.Data.Sqlite;
global using System.Data;
using CarCareAPI.Brokers.Storages;
using CarCareAPI.Controllers;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IStorageBroker, StorageBroker>();
var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.RegisterRoutes();

app.MapGet("/", () => Results.Redirect("/scalar/v1"));


app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
