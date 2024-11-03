using CarCareAPI.Models;
namespace CarCareAPI.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask InsertUserAsync(User user);
    IQueryable<User> SelectAllUsersAsync();
    ValueTask SelectUserByIdAsync(string userId);
    ValueTask UpdateUserAsync(User user);
    ValueTask DeleteUserAsync(string UserId);
}
